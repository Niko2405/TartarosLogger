namespace TartarosLogger
{
	public class Logger
	{
		public static readonly string Version = "1.7.0";
		public static string LogPath = "./";
		public static bool WriteLogInFile = true;

		/// <summary>
		/// Enable Debug logging
		/// </summary>
		public static bool DebugEnabled = false;
		
		#region INFO
		/// <summary>
		/// Info log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Info<T>(T text)
		{
			ResetColorsToDefault();
			
			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write("INFO");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("]:\t" + text);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [INFO]:\t{text}\n");
			}
		}
		#endregion

		#region WARNING
		/// <summary>
		/// Warning log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Warn<T>(T text)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write("WARN");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("]:\t" + text);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [WARN]:\t{text}\n");
			}
		}
		#endregion

		#region ERROR
		/// <summary>
		/// Error log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Error<T>(T text)
		{
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("ERROR");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("]:\t" + text);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [ERROR]:\t{text}\n");
			}
		}
		#endregion

		#region DEBUG
		/// <summary>
		/// Debug log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Debug<T>(T text)
		{
			if (!DebugEnabled)
				return;
			
			ResetColorsToDefault();

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("DEBUG");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("]:\t" + text);

			ResetColorsToDefault();

			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"{GetCurrentTime()} [DEBUG]:\t{text}\n");
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
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine($"======================[ {title} ]======================");
			if (WriteLogInFile)
			{
				File.AppendAllTextAsync($"{LogPath}latest.log", $"======================[ {title} ]======================");
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
