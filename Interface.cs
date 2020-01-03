using System;
using System.IO;

namespace Interface
{
	public interface ILogger
	{
		void WriteLog(string message);
	}

	public class ConsoleLogger : ILogger
	{
		public void WriteLog(string message)
		{
			Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
		}
	}

	public class FileLogger : ILogger
	{
		private StreamWriter writer;

		public FileLogger(string path)
		{
			writer = File.CreateText(path);
			writer.AutoFlush = true;
		}

		public void WriteLog(string message)
		{
			writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
		}
	}

	public class ClimateMoniter
	{
		private ILogger logger;

		public ClimateMoniter(ILogger logger)
		{
			this.logger = logger;
		}

		public void Start()
		{
			while (true)
			{
				Console.Write("온도를 입력하세요. : ");
				string temperature = Console.ReadLine();
				if(temperature == "")
				{
					break;
				}

				logger.WriteLog("현재 온도 : " + temperature);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			// 예제 그대로
			//ClimateMoniter moniter = new ClimateMoniter(new FileLogger("MyLog.txt"));
			// 비타민 퀴즈 8-1
			ClimateMoniter moniter = new ClimateMoniter(new ConsoleLogger());

			moniter.Start();
		}
	}
}
