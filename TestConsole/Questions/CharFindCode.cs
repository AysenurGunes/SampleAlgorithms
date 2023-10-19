//Create a function that takes a single character as an argument and returns the char code of its lowercased / uppercased counterpart.

//Examples
//Given that:
//  -"A" char code is: 65
//  - "a" char code is: 97

//CounterpartCharCode("A") ➞ 97

//CounterpartCharCode("a") ➞ 65
//Notes
//The argument will always be a single character.
//Not all inputs will have a counterpart (e.g. numbers), in which case return the input's char code.

namespace TestConsole.Questions
{
	public class CharFindCode
	{
		public  int CounterpartCharCode(char symbol)
		{
			return (int) symbol;
		}
	}
}
