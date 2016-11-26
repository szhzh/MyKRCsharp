using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex._5_ArrayWithPlacesGrad
{
    class Program
    {
        static void Main()
        {
            /* Стр.201/Зад.372-б)
                  Елементите на масива са населини места, започващи с главна буква. Да се състави ППГ за:
              б) извеждане на екрана на всички населени места, които съдържат в името си подниз "град" или "Град".
              Шрифтът на текста трябва да може да поддържа кирилица(такива са 'Consolas' и 'Lucida Console') !!!*/

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string[] cities = new string[]{"Ивайловград", "София", "Пловдив", "Асеновград", "Шумен", "Градешница", "Варна", "Бургас", "Силистра", "Русе"};
            Console.WriteLine("The result: ");
            ArrayContainGrad(cities);
        }
        static void ArrayContainGrad(string[] array)
        {
            string find = "град";
            string find1 = "Град";
            for (int i = 0; i < array.Length; i++)
            {
                bool contain = array[i].Contains("" + find);
                if (contain == true)
                {
                    Console.WriteLine("- " + array[i]);
                }
                bool contain1 = array[i].Contains("" + find1);
                if (contain1 == true)
                {
                    Console.WriteLine("- " + array[i]);
                }
            }
        }
    }
}
