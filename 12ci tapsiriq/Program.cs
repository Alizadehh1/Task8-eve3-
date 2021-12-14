using System;

namespace _12ci_tapsiriq
{
    class Program
    {
        
        //    12) Verilmihs 6 reqemli ededdin evveline ve axirina 8 artir.
        //    Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish
        //    Neticenin tek yerde dayanan reqemlerini 0 reqemi ile evez et.
        static void Main(string[] args)
        {
            int num;
            error1:
            Console.Write("6 Reqemli eded daxil edin: ");   //81234568
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 100000 || num > 999999)
            {
                Console.Clear();
                Console.WriteLine("Duzgun daxil edin!");
                goto error1;
            }
            num = num * 10 + 8;
            num = 80000000 + num;
            
            int num1 = num % 10000;
            int num2 = num / 10000;
            
            num1 = num1 * 10000 + num2;
                                                    //45688123    
            int counter = 1;

            int digits = 0;

            int digits1 = 0;

            

            while (num1>0)
            {
                digits1 = digits1 + num1 % 10;                           //0+3      //30+2
                num1 = num1 / 10;                                       //4568812   //456881
                digits1 = digits1 * 10;                                //30        //320
            }
            digits1 = digits1 / 10;
            



            while (digits1 > 0)
            {
                digits = digits + digits1 % 10;                         //0+3
                digits1 = digits1 / 10;                                 //4568812
                if (counter % 2 == 1)
                {
                    digits = digits * 0;
                }
                Console.Write(digits);
                counter++;
            }


        }
    }
}
