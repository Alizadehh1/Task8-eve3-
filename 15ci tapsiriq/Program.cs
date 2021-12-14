using System;

namespace _15ci_tapsiriq
{
    class Program
    {
        //15) IF operatoru ile yoxla. 
        //Verilmish ededdin 1-ile 365 arasinda olugunu yoxla(1 ve 365 ozude daxil olmaq sherti ile)
        //Ededin ilin hansi ayina dushduyunu tap.Ve hemin ay ve gune uygun hansi burc oldugunu goster
        static void Main(string[] args)
        {
            int num;
            step1:
            Console.Write("1-365 arasi eded secin: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num<1 || num>365)
            {
                Console.Clear();
                Console.WriteLine("Duzgun daxil edin!");
                goto step1;
            }
            else if (num>=1 && num<=31)
            {
                Console.WriteLine("Yanvar Ayidir!");
                if (num>=1 && num<=19)
                {
                    Console.WriteLine("Oğlaq Bürcü!");
                }
                if (num>=20 && num<=31)
                {
                    Console.WriteLine("Dolça Bürcü!");
                }
            }
            else if (num >=32  && num <= 59)
            {
                Console.WriteLine("Fevral Ayidir!");
                if (num >= 32 && num <=49 )
                {
                    Console.WriteLine("Dolça Bürcü!");
                }
                if (num >= 50 && num <= 59)
                {
                    Console.WriteLine("Balıqlar Bürcü!");
                }
            }
            else if (num >= 60 && num <= 90)
            {
                Console.WriteLine("Mart Ayidir!");
                if (num >= 60 && num <= 79)
                {
                    Console.WriteLine("Balıqlar Bürcü!");
                }
                if (num >= 80 && num <= 90)
                {
                    Console.WriteLine("Qoç Bürcü!");
                }
            }
            else if (num >= 91 && num <= 120)
            {
                Console.WriteLine("Aprel Ayidir!");
                if (num >= 91 && num <= 109)
                {
                    Console.WriteLine("Qoç Bürcü!");
                }
                if (num >= 110 && num <= 120)
                {
                    Console.WriteLine("Buğa Bürcü!");
                }
            }
            else if (num >= 121 && num <= 151)
            {
                Console.WriteLine("May Ayidir!");
                if (num >= 121 && num <= 140)
                {
                    Console.WriteLine("Buğa Bürcü!");
                }
                if (num >= 141 && num <= 151)
                {
                    Console.WriteLine("Ekizler Bürcü!");
                }
            }
            else if (num >= 152 && num <= 181)
            {
                Console.WriteLine("İyun Ayidir!");
                if (num >= 152 && num <= 171)
                {
                    Console.WriteLine("Ekizler Bürcü!");
                }
                if (num >= 172 && num <= 181)
                {
                    Console.WriteLine("Xerceng Bürcü!");
                }
            }
            else if (num >= 182 && num <= 212)
            {
                Console.WriteLine("İyul Ayidir!");
                if (num >= 182 && num <= 203)
                {
                    Console.WriteLine("Xerceng Bürcü!");
                }
                if (num >= 204 && num <= 212)
                {
                    Console.WriteLine("Şir Bürcü!");
                }
            }
            else if (num >= 213 && num <= 243)
            {
                Console.WriteLine("Avqust Ayidir!");
                if (num >= 213 && num <= 234)
                {
                    Console.WriteLine("Şir Bürcü!");
                }
                if (num >= 235 && num <= 243)
                {
                    Console.WriteLine("Qız Bürcü!");
                }
            }
            else if (num >= 244 && num <= 273)
            {
                Console.WriteLine("Sentyabr Ayıdır!");
                if (num >= 244 && num <= 265)
                {
                    Console.WriteLine("Qız Bürcü!");
                }
                if (num >= 266 && num <= 273)
                {
                    Console.WriteLine("Terezi Bürcü!");
                }
            }
            else if (num >= 274 && num <= 304)
            {
                Console.WriteLine("Oktyabr Ayıdır!");
                if (num >= 274 && num <= 295)
                {
                    Console.WriteLine("Terezi Bürcü!");
                }
                if (num >= 296 && num <= 304)
                {
                    Console.WriteLine("Eqreb Bürcü!");
                }
            }
            else if (num >= 305 && num <= 334)
            {
                Console.WriteLine("Noyabr Ayıdır!");
                if (num >= 305 && num <= 325)
                {
                    Console.WriteLine("Eqreb Bürcü!");
                }
                if (num >= 326 && num <= 334)
                {
                    Console.WriteLine("Oxatan Bürcü!");
                }
            }
            else if (num >= 335 && num <= 365)
            {
                Console.WriteLine("Dekabr Ayıdır!");
                if (num >= 335 && num <= 355)
                {
                    Console.WriteLine("Oxatan Bürcü!");
                }
                if (num >= 356 && num <= 365)
                {
                    Console.WriteLine("Oğlaq Bürcü!");
                }
            }


        }
    }
}
