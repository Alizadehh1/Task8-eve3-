using System;

namespace _10cu_tapsiriq
{
    class Program
    {
        //  10) IF operatoru ile yoxla. 
        //  6 dene eded verilib.Bu ededlerden hansi en boyukdur.
        static void Main(string[] args)
        {
            Console.Write("1ci ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("2ci ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("3ci ededi daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("4ci ededi daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("5ci ededi daxil edin: ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.Write("6ci ededi daxil edin: ");
            int f = Convert.ToInt32(Console.ReadLine());

            if (a>b && a>c && a>d && a>e && a>f)
            {
                Console.WriteLine($"En Boyuk Eded: {a}");
            }

            if (b > a && b > c && b > d && b > e && b > f)
            {
                Console.WriteLine($"En Boyuk Eded: {b}");
            }

            if (c > a && c > b && c > d && c > e && c > f)
            {
                Console.WriteLine($"En Boyuk Eded: {c}");
            }

            if (d > a && d > b && d > c && d > e && d > f)
            {
                Console.WriteLine($"En Boyuk Eded: {d}");
            }

            if (e > a && e > b && e > c && e > d && e > f)
            {
                Console.WriteLine($"En Boyuk Eded: {e}");
            }

            if (f > a && f > b && f > c && f > d && f > e)
            {
                Console.WriteLine($"En Boyuk Eded: {f}");
            }
        }
    }
}
