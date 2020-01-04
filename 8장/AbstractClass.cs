using System;

namespace AbstractClass
{
	public abstract class AbstractBase
	{
		protected void PrivateMethodA()
		{
			Console.WriteLine("AstractBase.PrivateMethodA()");
		}

		public void PublicMethodA()
		{
			Console.WriteLine("AbstractBase.PublicMethodA()");
		}

		public abstract void AbstractMethodA();
	}

	public class Derived : AbstractBase
	{
		public override void AbstractMethodA()
		{
			Console.WriteLine("Derived.AbstractMethodA()");
			PrivateMethodA();
		}
	}

	class AbstractClass
	{
		static void Main(string[] args)
		{
			AbstractBase obj = new Derived();
			obj.AbstractMethodA();
			obj.PublicMethodA();
		}
	}
}
