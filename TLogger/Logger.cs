namespace TLogger
{
	public class Logger
	{
		public static readonly string VERSION = "0.4";

		/// <summary>
		/// Info log
		/// </summary>
		/// <param name="text"></param>
		public static void Info(string text)
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			
			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write("INFO");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("]\t|\t" + text);

			// RESET COLOR
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [INFO]\t|\t{text}\n");
		}

		/// <summary>
		/// Warning log
		/// </summary>
		/// <param name="text"></param>
		public static void Warn(string text)
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write("WARNING");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("]\t|\t" + text);

			// RESET COLOR
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [WARNING]\t|\t{text}\n");
		}

		/// <summary>
		/// Error log
		/// </summary>
		/// <param name="text"></param>
		public static void Error(string text)
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

			Console.Write($"{GetCurrentTime()} [");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("ERROR");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("]\t|\t" + text);

			// RESET COLOR
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [ERROR]\t|\t{text}\n");
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
	}
}
