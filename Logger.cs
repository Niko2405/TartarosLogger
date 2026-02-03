namespace TartarosLogger
{
	public class Logger
	{
		/// <summary>
		/// Get current version of logger
		/// </summary>
		public static readonly string Version = "2.0.2";

		/// <summary>
		/// Set output path for log file
		/// </summary>
		public static string LogFilePath { get; set; } = "./";

		/// <summary>
		/// Should create log file
		/// </summary>
		public static bool WriteLogInFile { get; set; } = false;

		/// <summary>
		/// Enable Debug logging
		/// </summary>
		public static bool IsDebugEnabled { get; set; } = false;

		#region INFO
		/// <summary>
		/// Write info log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Info(string? eventSource, string? message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Write info log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Info(string? eventSource, bool? message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Write info log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Info(string? eventSource, int? message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}
		#endregion

		#region WARNING

		/// <summary>
		/// Write warning log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Warn(string? eventSource, string? message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Write warning log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Warn(string? eventSource, bool? message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Write warning log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Warn(string? eventSource, int? message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}
		#endregion

		#region ERROR

		/// <summary>
		/// Write error log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Error(string? eventSource, string? message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Write error log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Error(string? eventSource, bool? message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Write error log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Error(string? eventSource, int? message)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}
		#endregion

		#region DEBUG

		/// <summary>
		/// Write debug log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Debug(string? eventSource, string? message)
		{
			if (!IsDebugEnabled)
				return;

			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Write debug log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Debug(string? eventSource, bool? message)
		{
			if (!IsDebugEnabled)
				return;

			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Write debug log
		/// </summary>
		/// <param name="eventSource"></param>
		/// <param name="message"></param>
		public static void Debug(string? eventSource, int? message)
		{
			if (!IsDebugEnabled)
				return;

			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} {eventSource}: ");

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(message);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} {eventSource}: {message}{Environment.NewLine}");
			}
		}
		#endregion

		#region MISC
		/// <summary>
		/// Print Header with a title
		/// </summary>
		/// <param name="title"></param>
		public static void PrintHeader(string? title)
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"======================[ {title} ]======================");
			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"======================[ {title} ]======================{Environment.NewLine}");
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
				File.Delete($"{LogFilePath}latest.log");
			}
			catch (Exception e)
			{
				Error("ConfigCore", e.Message);
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
		#endregion
	}
}
