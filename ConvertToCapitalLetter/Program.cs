using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ConvertToCapitalLetter
{
    class Program
    {
        static void Main()
        {
            /* Стр.33/Зад.30
                Да се напише програма, която въвежда редовна буква от латинската азбука. 
            Програмата трябва да изведе съответната главна латинската буква. */

            Console.Write("Enter a letter from the latin alphabet: ");
            string letter = Console.ReadLine();
            PrimaryLetter(letter); 
        }
        static void PrimaryLetter(string letter)
        {
            int num = 0;
            bool result = int.TryParse(letter, out num);
            if (result == true)
            {
                Console.WriteLine("This " + "\"" + num + "\"" + " is not a letter! ");
            }
            else
            {
                if (letter.Length == 0)
                {
                    Console.WriteLine("You didn`t enter a letter !");
                }
                if (letter.Length == 1)
                {
                    Console.WriteLine("Capital letter: " + letter.ToUpper());
                }
                if (letter.Length > 1)
                {
                    Console.WriteLine("We asked for one letter !");
                }
            }
        }
    }
}
