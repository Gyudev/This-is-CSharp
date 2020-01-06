using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_2
{
	class Ex9_2
	{
		static void Main(string[] args)
		{
			var nameCard = new { Name = "유병규", Age = 26 };
			Console.WriteLine($"이름 : {nameCard.Name}, 나이 : {nameCard.Age}");

			var complex = new { Real = 3, Imaginary = -12 };
			Console.WriteLine($"Real : {complex.Real}, Imaginary : {complex.Imaginary}");
		}
	}
}
