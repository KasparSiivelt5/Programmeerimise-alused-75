using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            int numberParsed = Int16.Parse(number);

            if (numberParsed < 50)
            {
                Console.WriteLine("Sisesta number");
            }
            else
            {
                Console.WriteLine("Kõik ülejäänud numbrid");
            }
        }
    }
}
