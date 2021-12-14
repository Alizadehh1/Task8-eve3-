using System;

namespace _16ci_tapsiriq1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter=6;
            int digits;
            int digits1=10;
            error1:
            Console.Write("6 Reqemli eded daxil edin: ");   //151735                //123455
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 100000 || num > 999999)
            {
                Console.Clear();
                Console.WriteLine("Duzgun daxil edin!");
                goto error1;
            }
            while (num>0)
            {
                digits = num % 10;              //0         //0
                num /= 10;                      //10000     //1000
                if (digits==digits1)            
                {
                    counter = counter - 1;      //5
                }
                digits1 = digits;               //0         //0
            }
            Console.WriteLine(counter);



        }
    }
}
