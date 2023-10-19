namespace TestConsole
{
	public class AbstractFactoryDP
	{

	}

	abstract class ContientFactory
	{
		public abstract Herbivore CreateHerbivore();
		public abstract Carnivore CreateCarnivore();

	}

	abstract class Herbivore
	{
	}
	abstract class Carnivore
	{
		public abstract void Eat(Herbivore h);
	}

	class AfricaFactory : ContientFactory
	{
		public override Carnivore CreateCarnivore()
		{
			return new Lion();
		}

		public override Herbivore CreateHerbivore()
		{
			return new Wildebeest();
		}
	}

	class AmericaFactory : ContientFactory
	{
		public override Carnivore CreateCarnivore()
		{
			return new Wolf();
		}

		public override Herbivore CreateHerbivore()
		{
			return new Bison();
		}
	}

	class Wildebeest : Herbivore { }
	class Lion : Carnivore
	{
		public override void Eat(Herbivore h)
		{
			Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
		}
	}
	class Bison : Herbivore { }
	class Wolf : Carnivore
	{
		public override void Eat(Herbivore h)
		{
			Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
		}
	}

	class AnimalWorld
	{
		private Herbivore _herbivore;
		private Carnivore _carnivore;
		public AnimalWorld(ContientFactory factory)
		{
			_carnivore = factory.CreateCarnivore();
			_herbivore = factory.CreateHerbivore();
		}
		public void RunFoodChain() 
		{ 
		_carnivore.Eat(_herbivore);
		}
	}
}
