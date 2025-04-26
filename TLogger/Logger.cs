namespace TLogger
{
	public class Logger
	{
		public static readonly string Version = "0.5";
		
		/// <summary>
		/// Enable Debug logging
		/// </summary>
		public static bool DebugEnabled = false;
		
		/// <summary>
		/// Info log
		/// </summary>
		/// <param name="text"></param>
		public static void Info(string text)
		{
			ResetColorsToDefault();
			
			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write("INFO");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("]:\t" + text);

			ResetColorsToDefault();

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [INFO]:\t{text}\n");
		}

		/// <summary>
		/// Warning log
		/// </summary>
		/// <param name="text"></param>
		public static void Warn(string text)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write("WARN");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("]:\t" + text);

			ResetColorsToDefault();

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [WARN]:\t{text}\n");
		}

		/// <summary>
		/// Error log
		/// </summary>
		/// <param name="text"></param>
		public static void Error(string text)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("ERROR");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("]:\t" + text);

			ResetColorsToDefault();

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [ERROR]:\t{text}\n");
		}
		
		/// <summary>
		/// Debug log
		/// </summary>
		/// <param name="text"></param>
		public static void Debug(string text)
		{
			if (!DebugEnabled)
				return;
			
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.Write("DEBUG");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("]:\t" + text);

			ResetColorsToDefault();

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [DEBUG]:\t{text}\n");
		}
		
		/// <summary>
		/// Print Header with a title
		/// </summary>
		/// <param name="title"></param>
		public static void PrintHeader(string title)
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine($"======================[ {title} ]======================");
			ResetColorsToDefault();
		}
		
		/// <summary>
		/// Delete lastest.log
		/// </summary>
		public static void ResetLog()
		{
			try
			{
				File.Delete("latest.log");
			}
			catch (Exception)
			{
				return;
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
