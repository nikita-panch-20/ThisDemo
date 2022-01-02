using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisDemo
{
	abstract class Animal
	{
		public void Walk()
		{
			Console.WriteLine("Uses 4 legs");
		}

		//public abstract void Eat();
		//public abstract void Sound();
		/*
		public virtual void Eat()
		{
			Console.WriteLine("All animal eat");
		}

		public virtual void Sound()
		{
			Console.WriteLine("All animal make sound");
		}
		*/
	}
	class Dog : Animal
	{
		public Dog()
		{
			Console.WriteLine("Const of Dog called");
		}
		public void Eat()
		{
			Console.WriteLine("Eats veg-non");
		}
		public void Sound()
		{
			Console.WriteLine("Bow - Bow");
		}
	}
	class Cat : Animal
	{
		public Cat()
		{
			Console.WriteLine("Const of Cat called");
		}
		public void Eat()
		{
			Console.WriteLine("Non-veg");
		}

		public void Sound()
		{
			Console.WriteLine("Meooo..");
		}
	}
	/*
		class Cow : Animal
		{
			public void Eat()
			{
				Console.WriteLine("Only Veg");
			}

			public void Sound()
			{
				Console.WriteLine("Ammbo....");
			}
		}
	*/

	class InhDemo
    {
		void Display(Animal animal)
		{

			if (animal is Dog)
			{
				Dog d = (Dog)animal;
				d.Eat();
				d.Sound();
			}
			else if (animal is Cat)
			{
				Cat c = (Cat)animal;
				c.Eat();
				c.Sound();
			}
			//animal.Eat();
			//animal.Sound();
			animal.Walk();
		}
		static void Main()
		{
			InhDemo i = new InhDemo();
			Dog d = new Dog();
			//d.Eat();
			//d.Sound();
			//d.Walk();
			i.Display(d);
			Cat c = new Cat();
			//c.Eat();
			//c.Sound();
			//c.Walk();
			i.Display(c);
			//Cow c1 = new Cow();
			//i.Display(c1);

			/*
			Animal animal = new Dog();
			animal.Eat();
			animal.Sound();
			animal.Walk();

			animal = new Cat();
			animal.Eat();
			animal.Sound();
			animal.Walk();
			*/
			Console.ReadLine();
		}

	}
}
