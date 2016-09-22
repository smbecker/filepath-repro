###To repro the issue

* Create a Windows share exposed as 'Test' on your local machine
* Create a file named 'test.txt.~SS' in that shared directory (should be accessible from \\\localhost\Test\test.txt.~SS)
* Clone repo
* `dotnet restore`
* `dotnet run -f netcoreapp1.0`

###Expected Results
The output of the file created previously.

###Actual Results
```
Unhandled Exception: System.IO.DirectoryNotFoundException: Could not find a part of the path 'o\t\Test\test.txt.~SS'.
   at System.IO.Win32FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize, FileOptions options, FileStream parent)
   at System.IO.Win32FileSystem.Open(String fullPath, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize, FileOptions options, FileStream parent)
   at System.IO.FileStream.Init(String path, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize, FileOptions options)
   at System.IO.File.Open(String path, FileMode mode)
   at ConsoleApplication.Program.Main(String[] args)
```

You will receive the expected results if you run with the Desktop framework (`dotnet run -f net451`).