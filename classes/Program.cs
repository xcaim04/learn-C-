using System;

namespace OOP
{
    class Car
    {
        string color = "red";

        static void Main(string[] args)
        {
            Car volvo = new Car();
            Console.WriteLine(volvo.color);
        }

    }
}