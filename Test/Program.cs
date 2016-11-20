using System;

namespace Test
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Animal princess = new Dog();
			Animal fluffy = new Cat();
			princess.talk();
			fluffy.talk();
		}
	}
}
