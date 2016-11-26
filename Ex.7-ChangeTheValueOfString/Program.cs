using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7_ChangeTheValueOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Стр.196/Зад.362
                 Съставете ППГ change(S,X,Y), която при всяко срещане на подниза X в низа S го заменя с низа Y.*/

            Console.Write("Enter the sequence of characters: ");
            string line = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the character or the combination of characters that you wont to replace: ");
            string find = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("And now enter other characters which which you will replace them: ");
            string replace = Console.ReadLine();
            ReplaceElement(line, find, replace);
        }
        static void ReplaceElement(string str, string find, string replace)
        {
            bool contain = str.Contains("" + find);
            if (contain == true)
            {
                Console.WriteLine();
                Console.WriteLine("And that`s how it look`s: ");
                str = str.Replace("" + find, "" + replace);
                Console.WriteLine("---------------------------------------------|");
                Console.WriteLine(str);
                Console.WriteLine("---------------------------------------------|");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("I didn`t find that element, sorry ;(");
            }
        }

    }
}
