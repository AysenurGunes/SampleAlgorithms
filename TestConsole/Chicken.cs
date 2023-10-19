namespace TestConsole
{

	public interface IBird
	{
		Egg Lay();
		void Speak();
	}

	public class Chicken : IBird
	{
		public Chicken()
		{
			Console.WriteLine("A chicken.");
		}

		public Egg Lay()
		{
			return new Egg(new Func<Chicken>(() => new Chicken()));
		}

		public void Speak()
		{
			Console.WriteLine("Bawk!");
		}

	}

	public class Duck : IBird
	{
		public Duck()
		{
			Console.WriteLine("A duck.");
		}

		public Egg Lay()
		{
			return new Egg(new Func<Duck>(() => new Duck()));
		}

		public void Speak()
		{
			Console.WriteLine("Quack!");
		}
	}

	public class Egg
	{
		bool born = false;
		Func<IBird> create;

		public Egg(Func<IBird> createBird)
		{
			create = createBird;
		}

		public IBird Hatch()
		{
			if (!born)
			{
				Console.WriteLine("It's Alive!");
				born = true;
				return create();
			}
			else
			{
				Console.WriteLine("Egg already hatched");
			}

			return null;
		}
	}
}
