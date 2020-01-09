using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem_2
{
	public class Person
	{
		//string name;
		//int age;

		//public Person(string name, int age)
		//{
		//	this.name = name;
		//	this.age = age;
		//}

		public string Name { get; set; }
		public int Age { get; set; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}

	class Problem_2
	{
		static void Main(string[] args)
		{
			List<Person> data = new List<Person>();

			for (int i = 0; i < 3; i++)
			{
				string personData = Console.ReadLine();
				string[] name = personData.Split(new char[] { ' ' });

				Person person = new Person(name[0], int.Parse(name[1]));
				data.Add(person);
			
			}
			
			for(int i = 0; i < data.Count; i++)
			{
				for(int j = 0; j < data.Count; j++)
				{
					if (data[i].Age > data[j].Age)
					{
						Person tempPerson = data[i];
						data[i] = data[j];
						data[j] = tempPerson;
					}
				}
			}

			for(int i = 0; i < data.Count; i++)
			{
				Console.Write($"{data[i].Name}, {data[i].Age}\n");	
			}
		}
	}
}
