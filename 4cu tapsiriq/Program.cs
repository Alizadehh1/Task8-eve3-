using System;

namespace _4cu_tapsiriq
{
    class Program
    {
        //4) Verilmihs 2 reqemli ededin reqemleri eynidirmi?   Beli ve Xeyr cavabini yaz ekrana
        static void Main(string[] args)
        {
            int num;
            error1:
            Console.Write("2 Reqemli eded daxil edin: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num<10 || num>99)
            {
                Console.Clear();
                Console.WriteLine("2 Reqemli eded daxil et!!!");
                goto error1;
            }

            int num1 = num % 10;
            int num2 = num / 10;
            if (num1==num2)
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
