using System;

namespace GreetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja nime
            //programm küsib kasutaja perekonnanime
            //programm tervitab kasutajat, kasutades neid andmeid

            Console.WriteLine("Mis su nimi on?");

            string FirstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");

            string LastName = Console.ReadLine();

            Console.WriteLine($"Hello, {FirstName} {LastName}");




        }
    }
}
