using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("X");
            int x =int.Parse(Console.ReadLine());
            Console.WriteLine("Y");
            int y =int.Parse(Console.ReadLine());
            Console.WriteLine("Z");
            int z =int.Parse(Console.ReadLine());
            if (y>z)
            {
                Console.WriteLine("Csere volt");
                y = y + z;
                z = y - z;
                y = y - z;
            }
            int[] sz= new int[x];
            for (int i = 0; i < sz.Length; i++)
            {
                sz[i] = rnd.Next(y, z);
            }
            Console.WriteLine("Tömb feltöltve!");

            int osszeg = 0;
            for (int i = 0; i < sz.Length; i++)
                osszeg = osszeg + sz[i];

            int max = 0;
            for (int i = 0; i < sz.Length; i++)
                if (sz[i] > max) 
                {
                max = sz[i];
                }

            int min = z;
            for (int i = 0; i < sz.Length; i++)
                if (sz[i] < min)
                {
                    min = sz[i];
                }

            int atlag;
            atlag = osszeg / x;


            Console.WriteLine("A legnagyobb érték: {0}", max);
            Console.WriteLine("A legkisebb érték: {0}", min);
            Console.WriteLine("A érték összege: {0}", osszeg);
            Console.WriteLine("A érték átlaga: ");
            Console.WriteLine("Prímszám szerepel a tömbben: ");


            Console.ReadKey();
        }
    }
}
