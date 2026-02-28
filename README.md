# Smart File Renamer  
智能文件日期重命名工具

A lightweight Windows drag-and-drop utility that renames files by adding their **Last Modified Date** as a prefix.

一个轻量级 Windows 拖拽工具，用文件的“最后修改时间”作为前缀自动重命名文件。

---

## ✨ Features | 功能特点

- Drag and drop files into the window  
  支持拖拽文件到窗口

- Automatically reads file **Last Modified Date**  
  自动读取文件“最后修改时间”

- Rename format:  
  重命名格式：

```
yyyy-MM-dd filename.ext
```

- Skips files that are already renamed  
  自动跳过已添加日期的文件

- Built-in progress bar  
  内置进度条显示

- No PowerShell required  
  无需 PowerShell

- No batch script required  
  无需批处理脚本

- Windows 7 (64-bit) compatible  
  兼容 Windows 7 64 位

---

## 📦 Example | 示例

Before | 重命名前

```
photo.jpg
```

After | 重命名后

```
2026-02-28 photo.jpg
```

---

## 🚀 How to Use | 使用方法

1. Download `SmartRename.exe`
2. Run the application
3. Drag files into the window
4. Files will be renamed automatically

使用步骤：

1. 下载 `SmartRename.exe`
2. 双击运行
3. 将文件拖入窗口
4. 自动完成重命名

---

## 🛠 Build from Source | 从源码构建

No Visual Studio required.

无需安装 Visual Studio。

Open Command Prompt and run:

打开命令提示符执行：

```
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /target:winexe SmartRename.cs
```

This will generate:

将生成：

```
SmartRename.exe
```

---

## 🖥 System Requirements | 系统要求

- Windows 7 64-bit or later  
  Windows 7 64 位或更高版本

- .NET Framework 4.0+  
  .NET Framework 4.0 及以上

---

## 📜 License | 许可证

MIT License

This project is licensed under the MIT License.  
本项目基于 MIT 许可证开源。

See the `LICENSE` file for details.  
详细内容请查看 LICENSE 文件。
