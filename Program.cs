using System;

namespace haticeEtogluVizeOdevi3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Lutfen bir sayi giriniz.");
            string val = Console.ReadLine();
            int numberVal = Convert.ToInt32(val);
            int[] array = new int[numberVal];

            for(int i=0; i<array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }

            Console.Write("\n\nRandom olusturulmus sayilar. \n");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }

            Array.Sort(array);
            Console.Write("\n\nKucukten buyuge siralanmis. \n");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.Write("\n\nBuyukten kucuge siralanmis. \n");
            Array.Reverse(array);
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }

            int max = 0;
            int min = 999;

            foreach (int value in array)
            {
                if (value > max)
                    max = value;
                if (value < min)
                    min = value;
            }

            Console.Write("\n\nEn buyuk sayi : " + max + "\n");
            Console.Write("\nEn kucuk sayi : " + min + "\n");


            Console.Write("\n\nBenzeri olmayan sayılar : \n");
            for (int i = 0; i < array.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < array.Length; j++)
                {
                    if(i!=j && array[i] == array[j])
                    {
                        flag = false;
                    }
                }
                if(flag)
                    Console.Write(array[i] + " ");
            }

            Console.Write("\n\nAsal sayılar : \n");
            for (int i = 0; i < array.Length; i++)
            {
                bool flag = true;
                for (int j = 2; j < array[i]; j++)
                {
                    if (array[i]%j==0)
                    {
                        flag = false;
                    }
                }
                if (flag && array[i] != 1)
                    Console.Write(array[i] + " ");
            }

            Console.Write("\n\n");
        }
    }
}
