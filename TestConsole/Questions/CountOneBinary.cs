//Count the amount of ones in the binary representation of an integer. For example, since 12 is 1100 in binary, the return value should be 2.

//Examples
//CountOnes(0) ➞ 0

//CountOnes(100) ➞ 3

//CountOnes(999) ➞ 8
//Notes
//The input will always be a valid integer (number).

namespace TestConsole.Questions
{
	public class CountOneBinary
	{
		public int CountOnes(int i)
		{
			
			string binary = Convert.ToString(i, 2);

			return binary.Where(x => x == '1').Count();

		}

	}
}
