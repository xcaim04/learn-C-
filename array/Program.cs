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


    }
}

