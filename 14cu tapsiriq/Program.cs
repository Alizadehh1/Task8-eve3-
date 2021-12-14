using System;

namespace _14cu_tapsiriq
{
    class Program
    {
        //14) Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler( bu o demekdirki 1,2,3,4,5,6,7 reqemlide ola biler)
        //    Bu ededin evvelin 1 reqemini artir.
        static void Main(string[] args)
        {
            int num;
            
            int counter;
            

            step1:
            Console.Write("Maksimum 8 reqemli eded daxil edin: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num<0 || num>99999999)
            {
                Console.Clear();
                Console.WriteLine("Duzgun daxil edin!!");
                goto step1;
            }
            int num1 = num;

            counter = 0;
            while (num1>0)   
            {
                num1=num1 / 10;
                counter++;
            }
            
            if (counter == 1)
            {
                num = 10 + num;
                Console.WriteLine($"Your Result: {num}");
            }
            else if (counter == 2)
            {
                num = 100 + num;
                Console.WriteLine($"Your Result: {num}");
            }
            else if (counter == 3)
            {
                num = 1000 + num;
                Console.WriteLine($"Your Result: {num}");
            }
            else if (counter == 4)
            {
                num = 10000 + num;
                Console.WriteLine($"Your Result: {num}");
            }
            else if (counter == 5)
            {
                num = 100000 + num;
                Console.WriteLine($"Your Result: {num}");
            }
            else if (counter == 6)
            {
                num = 1000000 + num;
                Console.WriteLine($"Your Result: {num}");
            }
            else if (counter == 7)
            {
                num = 10000000 + num;
                Console.WriteLine($"Your Result: {num}");
            }
            else if (counter == 8)
            {
                num = 100000000 + num;
                Console.WriteLine($"Your Result: {num}");
            }
            


        }
    }
}
