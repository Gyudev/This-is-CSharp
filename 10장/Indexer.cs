using System;
using System.Collections;

namespace Indexer
{
	class MyList
	{
		private int[] array;

		public MyList()
		{
			array = new int[3];
		}

		public int this[int index]
		{
			get
			{
				return array[index];
			}

			set
			{
				if(index >= array.Length)
				{
					Array.Resize<int>(ref array, index + 1);
					Console.WriteLine($"Array Resized : {array.Length}");
				}

				array[index] = value;
			}
		}

		public int Length
		{
			get { return array.Length; }
		}
	}

	class Indexer
	{
		static void Main(string[] args)
		{
			MyList myList = new MyList();

			for(int i = 0; i < 6; i++)
			{
				myList[i] = i;
			}

			for(int i = 0; i < myList.Length; i++)
			{
				Console.WriteLine(myList[i]);
			}
		}
	}
}
