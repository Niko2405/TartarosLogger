﻿namespace TartarosLogger
{
	public class Logger
	{
		public static readonly string Version = "1.6.3";
		
		/// <summary>
		/// Enable Debug logging
		/// </summary>
		public static bool DebugEnabled = false;
		
		#region INFO
		/// <summary>
		/// Info log
		/// </summary>
		/// <param name="text">Message</param>
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
		/// Info log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Info(int text)
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
		/// Info log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Info(float text)
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
		/// Info log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Info(bool text)
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
		#endregion

		#region WARNING
		/// <summary>
		/// Warning log
		/// </summary>
		/// <param name="text">Message</param>
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
		/// Warning log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Warn(int text)
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
		/// Warning log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Warn(float text)
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
		/// Warning log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Warn(bool text)
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
		#endregion

		#region ERROR
		/// <summary>
		/// Error log
		/// </summary>
		/// <param name="text">Message</param>
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
		/// Error log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Error(int text)
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
		/// Error log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Error(float text)
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
		/// Error log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Error(bool text)
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
		#endregion

		#region DEBUG
		/// <summary>
		/// Debug log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Debug(string text)
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

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [DEBUG]:\t{text}\n");
		}
		
		/// <summary>
		/// Debug log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Debug(int text)
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

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [DEBUG]:\t{text}\n");
		}
		
		/// <summary>
		/// Debug log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Debug(float text)
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

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [DEBUG]:\t{text}\n");
		}
		
		/// <summary>
		/// Debug log
		/// </summary>
		/// <param name="text">Message</param>
		public static void Debug(bool text)
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

			File.AppendAllTextAsync($"latest.log", $"{GetCurrentTime()} [DEBUG]:\t{text}\n");
		}
		#endregion
		
		
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
