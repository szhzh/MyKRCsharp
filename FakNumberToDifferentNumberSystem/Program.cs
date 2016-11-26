using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakNumberToDifferentNumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    Да се изкарат последните четири цифри от факултетния ви номер, в двоична
             ,осмична и шестнайсетична бройна система.
             Fac.Number: 1601681007 */

            int myFakNum = 1007;
            Console.WriteLine("My faculty number is: "+ myFakNum);
            Console.WriteLine("----------------------------------------|");
            string binary = Convert.ToString(myFakNum, 2);
            Console.WriteLine("My binary faculty number is: "+ binary);
            Console.WriteLine("----------------------------------------|");
            string octa = Convert.ToString(myFakNum, 8);
            Console.WriteLine("My octa faculty number is: " + octa);
            Console.WriteLine("----------------------------------------|");
            string hex = Convert.ToString(myFakNum, 16);
            Console.WriteLine("My hexadecimal faculty number is: " + hex);
            Console.WriteLine("----------------------------------------|");

        }
    }
}
