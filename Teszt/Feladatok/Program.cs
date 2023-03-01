using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szam = new List<int>();
            for (int i = 0; i < 3; i++)
                szam.Add(int.Parse(Console.ReadLine())); //szam.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(szam.Max());

            Console.ReadKey();
        }
    }
}
