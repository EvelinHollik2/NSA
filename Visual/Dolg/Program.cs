using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolg
{
    internal class Program
    {
        //1
        //static void Main(string[] args)
        //{
        //List<int> l = new List<int>();
        //Random r = new Random();
        //for (int i = 0; i < 67000; i++)
        //{
        //    l.Add(r.Next(1, 100001));
        //}
        //Console.WriteLine("A legnagyobb szám: {0}", l.Max());
        //Console.ReadKey();
        //}

        //2
        //static void Main(string[] args)
        //{
        //List<int> l = new List<int>();
        //Random r = new Random();
        //Console.Write("Prímszámok:");
        //int a = 5;
        //while (l.Count<10)
        //{
        //    int b = r.Next(5, 10);
        //    int o = 0;
        //    for (int i = 1; i <= b; i++)
        //    {
        //        if (b % i == 0)
        //            o++;
        //    }
        //    if (o == 2)
        //    {
        //        l.Add(a);
        //        Console.WriteLine("\t{0}", l[a]);
        //        a++;
        //    }
        //}
        //Console.ReadKey();
        //}

        //3
        //static void Main(string[] args)
        //{
        //List<int> list = new List<int>();
        //Random random = new Random();
        //int a = 0;
        //while (list.Count < 5)
        //{
        //    int b = random.Next(1, 6);
        //    if (!list.Contains(a))
        //    {
        //        list.Add(a);
        //        Console.WriteLine("\t{0}", list[a]);
        //        a++;
        //    }
        //}
        //Console.ReadKey();
        //}

        //4
        //static void Main(string[] args)
        //{
        //Console.WriteLine("Adj meg egy 10 karakter hosszú szöveget: ");
        //string a=Console.ReadLine();
        //while (a.Length != 10)
        //{
        //    Console.WriteLine("Adj meg egy 10 karakter hosszú szöveget: ");
        //    a= Console.ReadLine();
        //}
        //for (int i = 0; i < a.Length; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        //Console.ReadKey();
        //}

        //5
        //static void Main(string[] args)
        //{
        //Console.WriteLine("Adj meg egy páros számot:");
        //int a = Convert.ToInt32(Console.ReadLine());
        //while (a % 2 !=0)
        //{
        //    Console.WriteLine("Nem páros. Add meg újra");
        //    a = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine("A páros szám: {0}", a);
        //
        //Console.ReadKey();
        //}

        //6
        //static void Main(string[] args)
        //{
        //}


        //7
        //static void Kezd(double a)
        //{
        //    if (a <= 40)
        //    {
        //        Console.WriteLine(a);
        //        a += 2;
        //        Kezd(a);
        //    }
        //}
        //static void Main(string[] args)
        //{ 
        //    Kezd(2);
        //    Console.ReadKey();
        //}


        //8
        //static void Main(string[] args)
        //{
        //    FileStream fs = new FileStream("adatok.txt", FileMode.Create);
        //    Console.WriteLine("Név:");
        //    Console.ReadLine();
        //    Console.WriteLine("Cím:");
        //    Console.ReadLine();
        //    Console.WriteLine("Kor:");
        //    Console.ReadLine();
        //Console.ReadKey();
        //}

        //9
        //static void Main(string[] args)
        //{
        //
        //}

        //10
        //static void Main(string[] args)
        //{
        //
        //}

        //11
        static void Main(string[] args)
        {
            Console.Write("Adj meg 5db számot egymás mellé: ");
            int szam = Convert.ToInt32(Console.ReadLine());

        }
    }
}
