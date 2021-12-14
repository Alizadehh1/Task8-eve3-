using System;

namespace _9cu_tapsiriq
{
    class Program
    {
   //     9) SWITCH operatoru ile yoxla.
   //Verilmish ededdin 1-ile 12 arasinda olugunu yoxla.(1 ve 12 ozude daxil olmaq sherti ile)
   //Eger bu eded 
			// 	1 olarsa-"Yanvar" sozunu 
			//	2 olarsa-"Fevral" sozunu
   //             ...
			//	12 olarsa-"Dekabr" sozunu yaz
        static void Main(string[] args)
        {
            int month;
            error1:
            Console.Write("Heftenin gununu daxil edin: ");
            month= Convert.ToInt32(Console.ReadLine());

            if (month<1 || month>12)
            {
                Console.Clear();
                Console.WriteLine("Duzgun daxil edin!!");
                goto error1;
            }
                

            switch (month)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;

                case 2:
                    Console.WriteLine("Fevral");
                    break;

                case 3:
                    Console.WriteLine("Mart");
                    break;

                case 4:
                    Console.WriteLine("Aprel");
                    break;

                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("İyun");
                    break;

                case 7:
                    Console.WriteLine("İyul");
                    break;
                
                case 8:
                    Console.WriteLine("Avqust");
                    break;

                case 9:
                    Console.WriteLine("Sentyabr");
                    break;

                case 10:
                    Console.WriteLine("Oktyabr");
                    break;

                case 11:
                    Console.WriteLine("Noyabr");
                    break;

                case 12:
                    Console.WriteLine("Dekabr");
                    break;

            }
        }
    }
}
