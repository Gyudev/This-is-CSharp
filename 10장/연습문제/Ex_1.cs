using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
	class Ex_1
	{
		static void Main(string[] args)
		{
			int[,] _2DArrA = new int[2, 2] { { 3, 2 }, { 1, 4 } };
			int[,] _2DArrB = new int[2, 2] { { 9, 2 }, { 1, 7 } };
			int sum = 0;
			int[,] _2DArrAB = new int[2, 2];


			for(int i = 0; i < 2; i++)
			{
				for(int j = 0; j < 2; j++)
				{
					for (int k = 0; k < 2; k++)
					{
						sum += _2DArrA[i, k] * _2DArrB[k, j];
					}
					_2DArrAB[i, j] = sum;
					sum = 0;
				}
			}

			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Console.Write($"[{i}, {j}]{_2DArrAB[i, j]} ");
				}
				Console.WriteLine();
			}
		}
	}
}
