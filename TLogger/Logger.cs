using System.Diagnostics;

namespace TLogger
{
	public class Logger
	{
		public static readonly string VERSION = "0.2";

		public static void Info(string text)
		{
#pragma warning disable CS8602
			var methodInfo = new StackTrace().GetFrame(1).GetMethod();
			var classname = methodInfo.ReflectedType.Name;
#pragma warning restore CS8602

			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			
			Console.Write($"{GetCurrentTime()} [{classname}]");

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write(" INFO ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("   - " + text);

			// RESET COLOR
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [{classname}] INFO    - {text}\n");
		}
		public static void Warn(string text)
		{
#pragma warning disable CS8602
			var methodInfo = new StackTrace().GetFrame(1).GetMethod();
			var classname = methodInfo.ReflectedType.Name;
#pragma warning restore CS8602

			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

			Console.Write($"{GetCurrentTime()} [{classname}]");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write(" WARNING ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("- " + text);

			// RESET COLOR
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [{classname}] WARNING - {text}\n");
		}
		public static void Error(string text)
		{
#pragma warning disable CS8602
			var methodInfo = new StackTrace().GetFrame(1).GetMethod();
			var classname = methodInfo.ReflectedType.Name;
#pragma warning restore CS8602

			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

			Console.Write($"{GetCurrentTime()} [{classname}]");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write(" ERROR ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("  - " + text);

			// RESET COLOR
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [{classname}] ERROR   - {text}\n");
		}

		private static string GetCurrentTime()
		{
			return DateTime.Now.ToString("HH:mm:ss.fff");
		}
	}
}
