# Tartaros-Logger

This module adds a very simple logger system that is very easy to use. Instead of a lot of configuration, it can be used directly.

## Description

TartarosLogger has several logging levels.
There are the following levels: INFO, WARNING, ERROR, DEBUG.
But DEBUG can only be output if IsDebugEnabled is set to True. Each output starts with the time at which the log was written. This is followed by the log level. The message is output immediately afterwards. The following can also be set. Whether the logs are saved and where they are saved.

## Getting Started

### Dependencies

* Recommended: Dotnet 5 - 10 Supported
* For Linux, MacOS and Windows

### Installing

* Just download via. NuGet: https://www.nuget.org/packages/TartarosLogger

### Executing program

* Namespace
```cs
using TartarosLogger;
```
* Reset logger file
```cs
Logger.ResetLog();
```

* Info log
```cs
Logger.Info(eventSource, text);
```

* Warning log
```cs
Logger.Warning(eventSource, text);
```

* Error log
```cs
Logger.Error(eventSource, text);
```

* Debug log
```cs
Logger.DebugEnabled = true;
Logger.Debug(text);
```

* Print a log header
```cs
Logger.PrintHeader(title);
```

* Deactivate LoggerFile
```cs
Logger.WriteLogInFile = false;
```

* Set log file path
```cs
Logger.LogFilePath = (e.g.) ./home/user/logs
```

## Version History
* 2.0.0
    * Remove obsolete functions
* 1.9.4
    * Expand readme.md
* 1.9.3
    * The logs must contain eventSource as an indicator of where it was called. (like Init, Core or etc.)
* 1.9.0
    * Update to DotNet 10
* 1.8.1
    * Add overloading function, to add optional eventSource (from where comes the log)
    * Fix new line an old platforms
* 1.7.0
    * Reduce code, by using generic methods.
* 1.6.3
    * Change Debug color from DarkBlue to Blue.

* 1.6.4
    * Add boolean variable (WriteLogInFile) to deactivate writing logs in file.
    * Add string variable (LogPath) to set the destination of the log file. _Default: ./ (current directory)_

## License

This project is licensed under the MIT License - see the LICENSE.md file for details.
