using System;

namespace _13cu_tapsiriq
{
    class Program
    {
        //13) Verilmish 7 reqemli eded polindromdursa  o zaman onun daxilnde nece dene 0 reqemi oldugunu tap?
        static void Main(string[] args)
        {
            int num;
            error1:
            Console.Write("7 Reqemli eded daxil edin: ");   //123  4  321    
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 1000000 || num > 9999999)
            {
                Console.Clear();
                Console.WriteLine("Duzgun daxil edin!");
                goto error1;
            }
            int num1 = num % 1000;          //321
            int num2 = num / 10000;         //123
            int digits1 = 0;
            while (num1>0)
            {
                digits1 = digits1 + num1 % 10;
                num1 = num1 / 10;
                digits1 = digits1 * 10;
            }
            digits1 = digits1 / 10;
            
            if (digits1==num2)
            {
                int counter = 0;
                int digits = 0;
                while (num>0)
                {
                    digits = num % 10;      //1
                    if (digits==0)
                    {
                        counter++;
                    }
                    num = num / 10;
                }
                Console.WriteLine($"Eded Polindrom'dur ve {counter} dene 0 var");
            }
            else
            {
                Console.WriteLine("Eded polindrom deyil!");
            }
            
        }
    }
}
