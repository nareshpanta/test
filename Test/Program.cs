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
			Animal sparrow2 = new Sparrow();

			princess.talk();
			fluffy.talk();
			sparrow.talk();
			sparrow2.talk();
		}
	}
}
