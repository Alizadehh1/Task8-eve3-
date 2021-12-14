using System;

namespace Task_eve3
{
    class Program
    {
        //1) verilmish ededin tek ve ya cut eded oldugunu yoxla
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("Eded cut ededdir!");
            }
            else
            {
                Console.WriteLine("Eded tek ededdir!");
            }
        }
    }
}
