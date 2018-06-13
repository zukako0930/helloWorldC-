using System;

namespace helloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] odd = new int[5];
            int[] even = new int[5];
            int odd_c = 0;
            int even_c = 0;
            Console.WriteLine($"odd:{odd.Length}");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("num:");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) { 
                    odd[odd.Length] = array[odd_c];
                    odd_c++;
                }
                else {
                    even[even.Length] = array[even_c];
                    even_c++;
                }
            }

            Console.Write($"odd:");
            foreach (var item in odd)
            {
                Console.WriteLine(item);
            }
            Console.Write("even:");
            foreach (var item in even)
            {
                Console.Write("odd:");
                Console.WriteLine(item);
            }

            ////5.2
            //for (int i = array.Length-1; i >= 0; i--)
            //{
            //    Console.Write($"{array[i]}");
            //}

            ////5.1
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]*2}");
            //}
            Console.ReadLine();            

            ////helloWorld
            //Console.WriteLine("Hello World!");
            //for (int i = 0; i <= 5; i++){
            //    Console.WriteLine($"{i}");
            //}
        }
    }
}
