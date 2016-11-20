using System;

namespace Test
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Animal princess = new Dog();
			Animal fluffy = new Cat();
			Animal sparrow = new Sparrow();
			princess.talk();
			fluffy.talk();
			sparrow.talk();
		}
	}
}
