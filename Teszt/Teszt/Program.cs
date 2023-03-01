using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool False = true;

            //hiba hárítás (try), hiba írása (catch):
            try
            { 
                Console.WriteLine("Adj egy számot: ");
                int a = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Ez nem szám!");
                False  = false;
            }


            if(False)
                Console.WriteLine("Igaz volt");
            else
            {
                Console.WriteLine("Nem volt igaz");
                Console.WriteLine("És még rossz is");
            }

            Console.ReadKey();
        }
    }
}
