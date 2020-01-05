using System;

namespace AnonymousTypeProperty
{
	class AnonymousTypeProperty
	{
		static void Main(string[] args)
		{
			var a = new { Name = "유병규", Age = "26" };
			Console.WriteLine($"Name : {a.Name}, Age : {a.Age}");

			var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
			Console.Write($"Subject : {b.Subject}, Score : ");
			foreach(var score in b.Scores)
			{
				Console.Write($"{score} ");
			}
			Console.WriteLine();
		}
	}
}
