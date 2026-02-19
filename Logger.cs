using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace TartarosLogger
{
	public class Logger
	{
		/// <summary>
		/// Get current version of logger
		/// </summary>
		public static readonly string Version = "2.1.1";

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

		/// <summary>
		/// Print info log
		/// </summary>
		/// <param name="message"></param>
		/// <param name="callerName"></param>
		public static void Info(string message, [CallerMemberName] string callerName = "")
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"{GetCurrentTime()} INFO  {callerName}: {message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} INFO  {callerName}: {message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Print warning log
		/// </summary>
		/// <param name="message"></param>
		/// <param name="callerName"></param>
		public static void Warning(string message, [CallerMemberName] string callerName = "")
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"{GetCurrentTime()} WARN  {callerName}: {message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} WARN  {callerName}: {message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Print error log
		/// </summary>
		/// <param name="message"></param>
		/// <param name="callerName"></param>
		public static void Error(string message, [CallerMemberName] string callerName = "")
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"{GetCurrentTime()} ERROR {callerName}: {message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} ERROR {callerName}: {message}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Print debug log
		/// </summary>
		/// <param name="message"></param>
		/// <param name="callerName"></param>
		public static void Debug(string message, [CallerMemberName] string callerName = "")
		{
			if (!IsDebugEnabled)
			{
				return;
			}
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"{GetCurrentTime()} DEBUG {callerName}: {message}");

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogFilePath}latest.log", $"{GetCurrentTime()} DEBUG {callerName}: {message}{Environment.NewLine}");
			}
		}

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
		#endregion
	}
}
