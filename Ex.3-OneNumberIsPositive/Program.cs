using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3_OneNumberIsPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            /* стр.35/Зад.36-e)
                Запишете израз, който е истина при изпълнението на указаното условие илъжа в противен случай:
            е)- поне едно от числата x,y,z да е положително*/

            Console.WriteLine("Enter three numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            IsTherePositiveNumber(a, b, c);
        }
        static void IsTherePositiveNumber(int a,int b,int c)
        {
            if (a > 0 || b > 0 || c > 0)
            {
                Console.WriteLine("-------------------------------------|");
                Console.WriteLine("There is a positive number !(true)");
                Console.WriteLine("-------------------------------------|");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-------------------------------------|");
                Console.WriteLine("There is a positive number !(false)");
                Console.WriteLine("-------------------------------------|");
            }

        }
    }
}
