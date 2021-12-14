using System;

namespace _3cu_tapsiriq
{
    class Program
    {
        //3) Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double num1 = num % 10;
            if (num1==7)
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyr");
            }
        }
    }
}
