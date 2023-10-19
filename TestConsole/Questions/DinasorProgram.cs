//The FireDragon species implements the IReptile interface.
//When a ReptileEgg hatches, a new reptile will be created of the same species that laid the egg.
//A system.InvalidOperationExcetion is thrown if a ReptileEgg tries to hatch more than once.

namespace TestConsole.Questions
{
    public class DinasorProgram
    {
        public void Main1()
        {
            var fireDragon = new FireDragon();
            var egg = fireDragon.Lay();
            var childFireDragon = egg.Hatch();
        }
    }
    public interface IReptile
    {
        ReptileEgg Lay();
    }
    public class FireDragon : IReptile
    {
        public FireDragon()
        {
            Console.WriteLine("Dragon");
        }
        public ReptileEgg Lay()
        {
            return new ReptileEgg(() => new FireDragon());
        }
    }
    public class ReptileEgg
    {
        Func<IReptile> func;
        IReptile valueFunc;
        public ReptileEgg(Func<IReptile> createReptile)
        {
            func = createReptile;
            valueFunc = func();
        }
        public IReptile Hatch()
        {
            if (valueFunc == null)
                return func();
            else
                throw new InvalidOperationException();

        }
    }
}
