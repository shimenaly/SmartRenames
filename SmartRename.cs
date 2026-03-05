using System;
using System.IO;
using System.Windows.Forms;

class SmartRenameForm : Form
{
    ProgressBar progressBar = new ProgressBar();
    Label statusLabel = new Label();

    public SmartRenameForm()
    {
        this.Text = "Smart File Renamer (Drag Files Here)";
        this.Width = 500;
        this.Height = 180;
        this.AllowDrop = true;

        progressBar.Width = 440;
        progressBar.Top = 40;
        progressBar.Left = 20;
        this.Controls.Add(progressBar);

        statusLabel.Width = 440;
        statusLabel.Top = 80;
        statusLabel.Left = 20;
        this.Controls.Add(statusLabel);

        this.DragEnter += DragEnterHandler;
        this.DragDrop += DragDropHandler;
    }

    void DragEnterHandler(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
            e.Effect = DragDropEffects.Copy;
    }

    void DragDropHandler(object sender, DragEventArgs e)
    {
        var droppedFiles = e.Data.GetData(DataFormats.FileDrop) as string[];
        if (droppedFiles == null || droppedFiles.Length == 0)
        {
            MessageBox.Show("No valid files were dropped.", "Nothing to do");
            return;
        }

        int total = droppedFiles.Length;
        int success = 0;
        int skipped = 0;
        int failed = 0;

        progressBar.Value = 0;
        progressBar.Maximum = total;

        foreach (string file in droppedFiles)
        {
            try
            {
                if (!File.Exists(file))
                {
                    failed++;
                    continue;
                }

                FileInfo info = new FileInfo(file);
                string datePrefix = info.LastWriteTime.ToString("yyyy-MM-dd") + " ";

                if (info.Name.StartsWith(datePrefix, StringComparison.Ordinal))
                {
                    skipped++;
                    continue;
                }

                if (string.IsNullOrEmpty(info.DirectoryName))
                {
                    failed++;
                    continue;
                }

                string newName = datePrefix + info.Name;
                string newPath = Path.Combine(info.DirectoryName, newName);

                if (File.Exists(newPath))
                {
                    failed++;
                    continue;
                }

                File.Move(file, newPath);
                success++;
            }
            catch
            {
                failed++;
            }
            finally
            {
                progressBar.Value++;
                statusLabel.Text = "Processing " + progressBar.Value + " / " + total;
                Application.DoEvents();
            }
        }

        MessageBox.Show(
            "Total: " + total +
            "\nRenamed: " + success +
            "\nSkipped: " + skipped +
            "\nFailed: " + failed,
            "Done");
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new SmartRenameForm());
    }
}
