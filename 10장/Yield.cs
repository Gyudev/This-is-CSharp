using System;
using System.Collections;

namespace Yield
{
	class MyEnumerator
	{
		int[] number = { 23, 12, 3, 4 };
		public IEnumerator GetEnumerator()
		{
			yield return number[0];
			yield return number[1];
			yield return number[2];
			yield break;
			yield return number[3];

		}
	}

	class Yield
	{
		static void Main(string[] args)
		{
			var obj = new MyEnumerator();
			foreach(int i in obj)
			{
				Console.WriteLine(i);
			}
		}
	}
}
