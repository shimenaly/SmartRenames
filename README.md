# Smart File Renamer

A lightweight Windows drag-and-drop tool that renames files by adding their last modified date as a prefix.

## Rename Format

```
yyyy-MM-dd filename.ext
```

Example:

photo.jpg

becomes:

2026-02-28 photo.jpg

---

## Features

- Drag and drop files
- Automatically reads file last modified date
- Skips already renamed files
- Built-in progress bar
- Windows 7 compatible
- No PowerShell required
- No batch script required

---

## How to Use

1. Run SmartRename.exe
2. Drag files into the window
3. Files will be renamed automatically

---

## Build (No Visual Studio Required)

Open Command Prompt and run:

C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /target:winexe SmartRename.cs

---

## License

MIT License