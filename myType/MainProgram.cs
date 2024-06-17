using System;
using Xcaim.MATCOM;

namespace Xcaim.Main;

public class Program
{
    public static void Main(string[] args)   
    {
        Libro book = new Libro("La excitante reencarnacion de un sonador", 44);
        string titleBook = book.Titulo;
        Console.WriteLine(titleBook);
    }
}