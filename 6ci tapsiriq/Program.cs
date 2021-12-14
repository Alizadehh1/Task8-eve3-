using System;

namespace _6ci_tapsiriq
{
    class Program
    {
        //6) Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana
        static void Main(string[] args)
        {
            int num;
            error1:
            Console.Write("3 Reqemli eded daxil edin: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num<100 || num>999)
            {
                Console.Clear();
                Console.WriteLine("3 reqemli deyil!");
                goto error1;
            }
            int digit1 = num / 100;
            int digit3 = num % 10;
            int digit2 = (num / 10) % 10;

            if (digit2==digit1+digit3)
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
