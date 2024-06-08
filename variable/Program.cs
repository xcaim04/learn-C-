using System;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Variables
            // type variableName = value;

            /*
                int - stores integers (whole numbers), without decimals, such as 123 or -123
                long - stores long integers
                float - stores floating point numbers
                double - stores long floating point numbers, with decimals, such as 19.99 or -19.99
                char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
                string - stores text, such as "Hello World". String values are surrounded by double quotes
                bool - stores values with two states: true or false
            */

            int age = 19;
            double heigth = 1.80;
            string name = "Carlos";
            const bool married = false; /*XD*/

            // Declare many variables of the same type
            int ageC=19, ageB=18, ageA=17;

            Console.WriteLine(age);
            Console.WriteLine(heigth);
            Console.WriteLine(name);
            Console.WriteLine(married);

            int a, b, c;
            a = 10;
            b = 5;
            c = a + b;

            Console.WriteLine("Sum(10, 5) = " + c);

            // Scientific Numbers
            float f1 = 35e3F;
            double d1 = 12E4D;
            double inf = 1e9;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.WriteLine(inf);


            /*
                C# Type Casting
                Type casting is when you assign a value of one data type to another type.

                In C#, there are two types of casting:

                Implicit Casting (automatically) - converting a smaller type to a larger type size
                char -> int -> long -> float -> double

                Explicit Casting (manually) - converting a larger type to a smaller size type
                double -> float -> long -> int -> char

            */

            // Implicit Casting

            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            // Explicit Casting

            myDouble = 9.78;
            myInt = (int) myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9

            /*
                Type Conversion Methods
                It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean,
                Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)
            */

            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool2 = true;

            Console.WriteLine(Convert.ToString(myInt2));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt2));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool2));   // convert bool to string

        }
    }

}