using System;
using System.Diagnostics;

namespace myNameSpace
{
    public class IO
    {
        public void greet()
        {
            Console.WriteLine("What's your name");
            String name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
        }

        public void takeATime()
        {
            Stopwatch crono = new Stopwatch();
            crono.Start();
            String message = Console.ReadLine();
            crono.Stop();
            Console.WriteLine(message.Length * 5 + "");
        }
        
        private void Main(String[] args
        {
            greet();
        }
    }
}