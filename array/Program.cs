using System;

namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        string[] cars;

        int[] numbers = {2, 1, 5, 3};

        int arrayLength = numbers.Length;
        Console.WriteLine($"The length of array is: {arrayLength}");

        /*Other Ways to Create an Array (String)*/

        // Create an array of four elements, and add values later
        string[] cars1 = new string[4];

        // Create an array of four elements and add values right away 
        string[] cars2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

        // Create an array of four elements without specifying the size 
        string[] cars3 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

        // Create an array of four elements, omitting the new keyword, and without specifying the size
        string[] cars4 = {"Volvo", "BMW", "Ford", "Mazda"};


        /*Alternatives*/
        // Declare an array
        string[] cars5;

        // Add values, using new
        cars = new string[] {"Volvo", "BMW", "Ford"};

        /*******************************************************************/

        // Loop Through Arrays

        for (int i = 0; i < cars.Length; i++) 
        {
            Console.WriteLine(cars[i]);
        }

        foreach (string i in cars) 
        {
            Console.WriteLine(i);
        }

        // Sort an int
        int[] myNumbers1 = {5, 1, 8, 9};
        Array.Sort(myNumbers1);

        foreach (int i in myNumbers1)
        {
            Console.WriteLine(i);
        }


        // ************************************

        // Bi-dimensional (MATRIX)

        // type[,] matrix = { {}, {} };
    // Good to know: The single comma [,] specifies that the array is two-dimensional. A three-dimensional array would have two commas: int[,,].

        int[,] numbers1 = { {2, 1, 4}, {3, 5, 1} };

        Console.WriteLine(numbers1[0, 2]);  // Outputs 4

        numbers1[0, 0] = 5;  // Change value to 5
        Console.WriteLine(numbers1[0, 0]); // Outputs 5 instead of 1


        // Loop a matrix
        foreach (int i in numbers1)
        {
            Console.Write(i + " ");
        } 


        /* You can also use a for loop. For multidimensional arrays, you need one loop for each of the array's dimensions.

        Also note that we have to use GetLength() instead of Length to specify how many times the loop should run:

        Example */

        for (int i = 0; i < numbers.GetLength(0); i++) 
        { 
            for (int j = 0; j < numbers.GetLength(1); j++) 
            { 
                Console.WriteLine(numbers[i, j]); 
            } 
        }  

    }
}

