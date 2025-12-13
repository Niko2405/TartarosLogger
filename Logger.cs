namespace TartarosLogger
{
	public class Logger
	{
		/// <summary>
		/// Get current version of logger
		/// </summary>
		public static readonly string Version = "1.9.0";

		/// <summary>
		/// Set output path for log file
		/// </summary>
		public static string LogPath { get; set; } = "./";

		/// <summary>
		/// Should create log file
		/// </summary>
		public static bool WriteLogInFile { get; set; } = true;

		/// <summary>
		/// Enable Debug logging
		/// </summary>
		public static bool IsDebugEnabled { get; set; } = false;

		#region INFO
		/// <summary>
		/// Write info log
		/// </summary>
		/// <param name="message">Message</param>
		public static void Info<T>(T message)
		{
			ResetColorsToDefault();
			
			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write("INFO");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"]:\t{message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [INFO]:\t{message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Write info log
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Info<T>(T eventSource, T message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write("INFO");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"]\t[{eventSource}]:\t{message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [INFO]\t[{eventSource}]:\t{message}{Environment.NewLine}");
			}
		}
		#endregion

		#region WARNING
		/// <summary>
		/// Write warning log
		/// </summary>
		/// <param name="message">Message</param>
		public static void Warn<T>(T message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write("WARN");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"]:\t{message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [WARN]:\t{message}{Environment.NewLine}");
			}
		}
		
		/// <summary>
		/// Write warning log
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Warn<T>(T eventSource, T message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write("WARN");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"]\t[{eventSource}]:\t{message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [WARN]\t[{eventSource}]:\t{message}{Environment.NewLine}");
			}
		}
		#endregion

		#region ERROR
		/// <summary>
		/// Write error log
		/// </summary>
		/// <param name="message">Message</param>
		public static void Error<T>(T message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("ERROR");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"]:\t{message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [ERROR]:\t{message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Write error log
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Error<T>(T eventSource, T message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("ERROR");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"]\t[{eventSource}]:\t{message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [ERROR]\t[{eventSource}]:\t{message}{Environment.NewLine}");
			}
		}
		#endregion

		#region DEBUG
		/// <summary>
		/// Write debug log
		/// </summary>
		/// <param name="message">Message</param>
		public static void Debug<T>(T message)
		{
			if (!IsDebugEnabled)
				return;
			
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("DEBUG");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"]:\t{message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [DEBUG]:\t{message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Write debug log
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Debug<T>(T eventSource, T message)
		{
			if (!IsDebugEnabled)
				return;

			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("DEBUG");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"]\t[{eventSource}]:\t{message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [DEBUG]\t[{eventSource}]:\t{message}{Environment.NewLine}");
			}
		}
		#endregion


		/// <summary>
		/// Print Header with a title
		/// </summary>
		/// <param name="title"></param>
		public static void PrintHeader<T>(T title)
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"======================[ {title} ]======================");
			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"======================[ {title} ]======================{Environment.NewLine}");
			}
			ResetColorsToDefault();
		}
		
		/// <summary>
		/// Delete lastest.log
		/// </summary>
		public static void ResetLog()
		{
			try
			{
				File.Delete($"{LogPath}latest.log");
			}
			catch (Exception e)
			{
				Error(e.Message);
			}
		}

		/// <summary>
		/// Get current time
		/// </summary>
		/// <returns></returns>
		private static string GetCurrentTime()
		{
			return DateTime.Now.ToString("HH:mm:ss.fff");
		}
		
		/// <summary>
		/// Reset Console Back- and Foreground to default value
		/// </summary>
		private static void ResetColorsToDefault()
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
