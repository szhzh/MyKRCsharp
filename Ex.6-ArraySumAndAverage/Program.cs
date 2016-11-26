using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._6_ArraySumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Стр.129/Зад.229-a)
                Да се въведат три едномерни масива от цели числа, съответно с m, n и k на брой елементи.
            Да се намерят и изведат:
            а) сумата на елементите на всеки масив, както и средноаритметичното на трите суми.*/

            Console.Write("Write the length of the first array: ");
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            int suma = MakeAndSumOfArray(a, m);
            Console.WriteLine("The sum of the first array is: "+suma);
            Console.WriteLine("------------------------------------------------|");
            Console.Write("Write the length of the second array: ");
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[n];
            int sumb = MakeAndSumOfArray(b, n);
            Console.WriteLine("The sum of the second array is: " + sumb);
            Console.WriteLine("------------------------------------------------|");
            Console.Write("Write the length of the third array: ");
            int k = int.Parse(Console.ReadLine());
            int[] c = new int[k];
            int sumc = MakeAndSumOfArray(c, k);
            Console.WriteLine("The sum of the third array is: " + sumc);
            Console.WriteLine("------------------------------------------------|");
            double average = (suma + sumb + sumc) / (double)3;
            Console.WriteLine("The average value of the three arrays is: {0:f2}", average);
        }
        static int MakeAndSumOfArray(int[] array,int length)
        {
            int suma = 0;
            array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("element[" + "{0}" + "]=", i);
                array[i] = int.Parse(Console.ReadLine());
                suma = suma + array[i];
            }
            return suma;
 
        }

    }
}
