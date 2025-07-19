# Tartaros-Logger

This module adds a very simple logger system that is very easy to use. Instead of a lot of configuration, it can be used directly.

## Description

TartarosLogger has several logging levels.
There are the following levels: INFO, WARNING, ERROR, DEBUG.
But DEBUG can only be output if IsDebugEnabled is set to True. Each output starts with the time at which the log was written. This is followed by the log level. The message is output immediately afterwards. The following can also be set. Whether the logs are saved and where they are saved.

## Getting Started

### Dependencies

* Recommended: Dotnet 8 - 9 Supoorted
* For Linux, MacOS and Windows

### Installing

* Just download via. NuGet: https://www.nuget.org/packages/TartarosLogger

### Executing program

* Namespace
```
using TartarosLogger;
```
* Reset logger file
```
Logger.ResetLog();
```

* Info log
```
Logger.Info(text);
```

* Warning log
```
Logger.Warning(text);
```

* Error log
```
Logger.Error(text);
```

* Debug log
```
Logger.DebugEnabled = true;
Logger.Debug(text);
```

* Print a log header
```
Logger.PrintHeader(title);
```

* Deactivate LoggerFile
```
Logger.WriteLogInFile = false;
```

## Version History

* 1.6.3
    * Change Debug color from DarkBlue to Blue

* 1.6.4
    * Add boolean variable (WriteLogInFile) to deactivate writing logs in file.
    * Add string variable (LogPath) to set the destination of the log file. _Default: ./ (current directory)_

## License

This project is licensed under the MIT License - see the LICENSE.md file for details
