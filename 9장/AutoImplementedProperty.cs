﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedProperty
{
	class BirthdayInfo
	{
		public string Name { get; set; } = "Unknown";
		public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);

		public int Age
		{
			get
			{
				return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
			}
		}
	}

	class AutoImplementedProperty
	{
		static void Main(string[] args)
		{
			BirthdayInfo birth = new BirthdayInfo();
			Console.WriteLine($"Name : {birth.Name}");
			Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
			Console.WriteLine($"Age : {birth.Age}\n");

			birth.Name = "병규";
			birth.Birthday = new DateTime(1995, 5, 15);
			Console.WriteLine($"Name : {birth.Name}");
			Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
			Console.WriteLine($"Age : {birth.Age}");
		}
	}
}
