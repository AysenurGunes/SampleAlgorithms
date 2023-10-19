//Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.

//To illustrate:

//"123"
//We reverse "123" to get "321" and then add "123" to the end, resulting in "321123".

//Examples
//ReverseAndNot(123) ➞ "321123"

//ReverseAndNot(152) ➞ "251152"

//ReverseAndNot(123456789) ➞ "987654321123456789"
//Notes
//i is a non-negative integer.
//Bonus: By using System.Linq this should be completed in one line of code.
using System.Text;

namespace TestConsole.Questions
{
	public class ReverseAndNot
	{
		public string ReverseNot(int i)
		{
			return String.Concat(String.Join("",i.ToString().Reverse()), i.ToString());
		}
	}
}
