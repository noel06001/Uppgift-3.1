using System;

namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din ålder");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 50) {
                Console.WriteLine("Du får vara med i seniormästerskapen");
            }
            else
            {
                Console.WriteLine("Du får tyvärr inte delta i seniormästerskapen");
                Console.ReadKey();
            }
        }
    }
}