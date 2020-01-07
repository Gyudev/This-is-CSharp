using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_1
{
	class NameCrad
	{
		public int Age { get; set; }
		public string Name { get; set; }
	}

	class Ex9_1
	{
		static void Main(string[] args)
		{
			NameCrad myCard = new NameCrad() { Age = 26, Name = "유병규" };

			Console.WriteLine($"나이 : {myCard.Age}");
			Console.WriteLine($"이름 : {myCard.Name}");
		}
	}
}
