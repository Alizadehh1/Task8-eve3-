using System;

namespace _2ci_tapsiriq
{
    class Program
    {
        //2) 2 eded verilib. Eger I eded II edede tam bolunurse o zaman cavabi cixart. 
        //Eks halda  "bolunmur" sozunu cap et
        static void Main(string[] args)
        {
            Console.Write("1ci ededi daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("2ci ededi daxil edin: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num%num1==0)
            {
                Console.WriteLine("Ededler bir birine qaliqsiz bolunur!");
            }
            else
            {
                Console.WriteLine("Bolunmur!!");
            }

        }
    }
}
