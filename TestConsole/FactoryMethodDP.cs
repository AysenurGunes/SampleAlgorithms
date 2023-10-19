namespace TestConsole
{
	public abstract class FactoryMethodDP
	{
		public abstract IProduct FactoryMethod();

		public string SomeOperation()
		{
			var product = FactoryMethod();

			var result = "Creator: The same creator's code has just wordked with" + product.Operation();
			return result;
		}
	}

	public interface IProduct
	{
		string Operation();
	}
	public class ConcreteProduct1 : IProduct
	{
		public string Operation()
		{
			return "{Return of Concrete Product 1}";
		}
	}

	public class ConcreteProduct2 : IProduct
	{
		public string Operation()
		{
			return "{Return of Concrete Product 2}";
		}
	}

	public class ConcreteCreator1 : FactoryMethodDP
	{
		public override IProduct FactoryMethod()
		{
			return new ConcreteProduct1();
		}

	}
	public class ConcreteCreator2 : FactoryMethodDP
	{
		public override IProduct FactoryMethod()
		{
			return new ConcreteProduct2();
		}
		
	}

	public class ClientCode
	{
		public ClientCode(FactoryMethodDP factoryMethodDP)
		{
			Console.WriteLine("Client: I'm not aware of the creator's class," + "but it still works.\n" + factoryMethodDP.SomeOperation());
		}
		

	}
}
