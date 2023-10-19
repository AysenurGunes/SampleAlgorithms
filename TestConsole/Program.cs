using TestConsole;
using TestConsole.Questions;

public class Program
{
	public static void Main(string[] args)
	{


		#region AbstractFactoryDP
		//ContientFactory africa = new AfricaFactory();
		//AnimalWorld world = new AnimalWorld(africa);
		//world.RunFoodChain();

		//ContientFactory america = new AmericaFactory();
		//world = new AnimalWorld(america);
		//world.RunFoodChain();

		//Console.ReadKey(); 
		#endregion

		#region FactoryMethodDP
		//Console.WriteLine("fsdfs1");
		//ClientCode clientCode = new ClientCode(new ConcreteCreator1());
		//Console.WriteLine("fsdfs2");
		//ClientCode clientCode2 = new ClientCode(new ConcreteCreator2());

		//DinasorProgram dinasorProgram = new DinasorProgram();
		//dinasorProgram.Main1();

		#endregion

		#region Chicken
		/*
	Console.WriteLine("<Chicken_Section>");

	var chicken1 = new Chicken();
	var egg = chicken1.Lay();
	var childChicken = egg.Hatch();
	childChicken.Speak();
	//egg should be already hatched
	egg.Hatch();

	Console.WriteLine("</Chicken_Section>\n");
	Console.WriteLine("<Duck_Section>");

	var howardTheDuck = new Duck();
	var duckEgg = howardTheDuck.Lay();
	var babyHowie = duckEgg.Hatch();
	babyHowie.Speak();
	//egg should be already hatched
	duckEgg.Hatch();

	Console.WriteLine("</Duck_Section>");
	*/
		#endregion

		#region DinasorProgram
		//DinasorProgram dinasorProgram = new DinasorProgram();
		//dinasorProgram.Main1(); 
		#endregion

		#region TextMessage
		//TextMessage textMessage = new TextMessage();
		//textMessage.Main2();
		#endregion

		#region CharFindCode
		//CharFindCode charFindCode = new CharFindCode();
		//Console.WriteLine(charFindCode.CounterpartCharCode('2'));
		#endregion

		#region CountOneBinary
		CountOneBinary countOneBinary = new CountOneBinary();
		Console.WriteLine(countOneBinary.CountOnes(510));
		#endregion


	}
}
