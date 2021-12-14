using System;

namespace _5ci_tapsiriq
{
    class Program
    {
        //    5) Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman
        //       hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.

        static void Main(string[] args)
        {
            int num;
            error1:
            Console.Write("2 Reqemli eded daxil edin: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num>=10 && num<100)
            {
                int num1 = num % 10;
                int num2 = num / 10;
                int sumofdigits = num1 + num2;
                if (sumofdigits%2==0)
                {
                    int multiplyofdigits = num1 * num2;
                    Console.WriteLine($"Ededin Reqemleri Hasili: {multiplyofdigits}");
                }
                else
                {
                    Console.WriteLine("Reqemleri Cemi Tekdir!");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("2 Reqemli Deyil!!");
                goto error1;
            }
        }
    }
}
