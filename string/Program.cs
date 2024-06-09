using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Carlos";
            string greeting = "Nice to meet you!", greeting2 = "Hi";

            int strLength = greeting.Length;
            Console.WriteLine("The length of the text is: " + strLength);

            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            // Interpolation
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            // You can also find the index position of a specific character in a string, by using the IndexOf() method:
            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            /*
                Another useful method is Substring(), 
                which extracts the characters from a string, starting from the specified character position/index, 
                and returns a new string. This method is often used together with IndexOf() to get the specific character position:
            */

            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);

        }
    }    
}