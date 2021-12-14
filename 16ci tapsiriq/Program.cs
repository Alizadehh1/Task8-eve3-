using System;

namespace _16ci_tapsiriq
{
    class Program
    {
        //16)* Verilmish 6 reqemli ededde nece unikal reqem var ?
        //  (UNIKAL- Ededin daxilde her reqemden bir numayende secilecek.Yekunda nece numayende olacaq?)
        static void Main(string[] args)
        {
            int[] arr = new int[0];
            int num;
            int digit = 0;

            Console.Write("6 Reqemli eded daxil edin: ");
            num = Convert.ToInt32(Console.ReadLine());      //151785

            
            while (num>0)
            {
                digit = num % 10;               //5
                num = num / 10;             //15178
                if (Array.IndexOf(arr,digit)==-1)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = digit;            
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"{arr.Length} dene unikal reqem var!!");
        }
    }
}
