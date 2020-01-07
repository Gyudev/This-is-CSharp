using System;

namespace _2DArray
{
	class _2DArray
	{
		static void Main(string[] args)
		{
			int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

			/*for (int i = 0; i < arr.GetLength(0); i++)
			{
				for(int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write($"[{i}, {j}] : {arr[i, j]} ");
				}
				Console.WriteLine();
			}*/
			foreach(int num in arr)
			{
				Console.Write($"{num} ");
			}
			Console.WriteLine();

			int[,] arr2 = new int[,] { { 7, 8, 9 }, { 10, 11, 12 } };

			for (int i = 0; i < arr2.GetLength(0); i++)
			{
				for (int j = 0; j < arr2.GetLength(1); j++)
				{
					Console.Write($"[{i}, {j}] : {arr2[i, j]} ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			int[,] arr3 = { { 13, 14, 15 }, { 16, 17, 18 } };

			for (int i = 0; i < arr3.GetLength(0); i++)
			{
				for (int j = 0; j < arr3.GetLength(1); j++)
				{
					Console.Write($"[{i}, {j}] : {arr3[i, j]} ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
