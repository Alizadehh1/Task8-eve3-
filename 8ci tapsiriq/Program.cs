using System;

namespace _8ci_tapsiriq
{
    class Program
    {
                //     8) SWITCH operatoru ile yoxla.
                //Verilmish ededdin sonuncu reqemi
                // 	1 olarsa-"I gun" sozunu
                //	2 olarsa-"II gun" sozunu
                //             ...
                //	7 olarsa-"VI gun" sozunu yaz
        static void Main(string[] args)
        {
            Console.Write("Heftenin gununu daxil edin: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                Console.WriteLine("I gun");
                break;

                case 2:
                Console.WriteLine("II gun");
                break;

                case 3:
                Console.WriteLine("III gun");
                break;

                case 4:
                Console.WriteLine("IV gun");
                break;

                case 5:
                Console.WriteLine("V gun");
                break;

                case 6:
                Console.WriteLine("VI gun");
                break;

                case 7:
                Console.WriteLine("VII gun");
                break;  
            }







        }
    }
}
