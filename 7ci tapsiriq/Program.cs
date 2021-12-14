using System;

namespace _7ci_tapsiriq
{
    class Program
    {
        //7) Verilmish 3 reqemli ededdin reqemleri cemi I reqemin kvadratina beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana
        static void Main(string[] args)
        {
            int num;
            error1:
            Console.Write("3 Reqemli eded daxil edin: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 100 || num > 999)
            {
                Console.Clear();
                Console.WriteLine("3 reqemli deyil!");
                goto error1;
            }
            double digit1 = Math.Pow(num / 100, 2);
            int sumofdigits = 0;
            while (num>0)
            {
                sumofdigits = sumofdigits + num % 10;
                num = num / 10;
            }      
            if (sumofdigits== digit1)
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
