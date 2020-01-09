using System;
using System.Collections;

namespace Problem_1
{
	class Problem_1
	{
		static void Main(string[] args)
		{
			ArrayList numData = new ArrayList();
			ArrayList tempData = new ArrayList();

			for(int i = 0; i < 7; i++)
			{
				string num = Console.ReadLine();
				numData.Add(double.Parse(num));
			}

			numData.Sort();

			for(int i = 0; i < numData.Count; i++)
			{
				Console.Write($"{numData[i]} ");
			}
		}
	}
}
