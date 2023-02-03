
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur gammal är du? : ");
            int ålder = Convert.ToInt32(Console.ReadLine());

            if (ålder >= 50 ) 
            {
                Console.WriteLine("Du får vara med i seniormästerskapet");
            }

            else
            {
                Console.WriteLine("Du får inte vara med i seniormästerskapet");
            }



        }
    }
}
