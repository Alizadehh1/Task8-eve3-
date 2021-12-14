using System;

namespace _11ci_tapsiriq
{
    class Program
    {
        //    11)   Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse 
        //          o zaman
        //          bu ededdin ilk 2 reqemini son 2 reqemine yapishdir.   
        //          Neticenin ustune ortaya dushen 2 reqemini gel. 
        static void Main(string[] args)
        {
            int num;
            error1:
            Console.Write("6 Reqemli eded daxil edin: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num<100000 || num>999999)
            {
                Console.Clear();
                Console.WriteLine("Duzgun daxil edin!");
                goto error1;
            }

            int num1 = num / 1000;
            int num2 = num % 1000;
            int digits = 0;
            int digits1 = 0;
            while (num1>0)
            {
                digits = digits + num1 % 10;
                num1 = num1 / 10;
            }
            while (num2>0)
            {
                digits1 = digits1 + num2 % 10;
                num2 = num2 / 10;
            }
            if (digits1==digits)
            {
                int num3 = num / 10000; //12
                num = num * 100 + num3;
                int num4 = (num / 1000) % 100;
                num = num + num4;
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Beraber Deyil!");
            }

        }
    }
}
