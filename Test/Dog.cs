using System;
namespace Test
{
	public class Dog:Animal
	{
		public Dog()
		{
		}

		public override void talk()
		{
			System.Console.WriteLine("Woof Woof");
		}
	}
}
