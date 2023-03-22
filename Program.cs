using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            string line = Console.ReadLine(); //исходная строка
            //            HashSet<char> setLine = TranslateLineToSet(line); //множество символов исходной строки
            //            PrintSet(setLine);
            //            HashSet<char> setDigit = new HashSet<char> { 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };// множество символов, которые нужно найти
            //            PrintSet(setDigit);
            //            HashSet<char> newSet = setLine; // копия исходного множества
            //            newSet.IntersectWith(setDigit); //пересечение 
            //            PrintSet(newSet);
            //            Console.ReadKey();
            //        }
            //        private static HashSet<char> TranslateLineToSet(string word)
            //        {
            //            HashSet<char> setWord = new HashSet<char>();
            //            foreach (char c in word)
            //            {
            //                setWord.Add(c);
            //            }
            //            return setWord;
            //        }
            //        private static void PrintSet(HashSet<char> set)
            //        {
            //            foreach (char c in set)
            //            {
            //                Console.Write($"{c} ");
            //            }
            //            Console.WriteLine();
            //        }
            //    }

            //}
            
            
            Console.WriteLine("Задание 2");
            string[] fossils = {"aluminum","basalt","breccia","calcite","chalk",
                "cinder","clay", "diamond","emerald","flint"};
            string[] fossils1 = { "aluminum", "breccia", "calcite", "chalk" };
            string[] fossils2 = { "basalt", "emerald", "diamond", "breccia" };
            string[] fossils3 = { "cinder", "flint", "clay" };
            string[] fossils4 = { "aluminum", "emerald", "diamond" };
            string[] fossils5 = { "basalt", "aluminum" };
            PrintSet(fossils);
            PrintSet(fossils1);
            PrintSet(fossils2);
            PrintSet(fossils3);
            PrintSet(fossils4);
            PrintSet(fossils5);
            Console.WriteLine("Входит в 1 множество");
            PrintSet(fossils1);

            Console.WriteLine("НЕ входит в 3 множество:");
            PrintSet(fossils.Except(fossils3));
            Console.ReadLine();
        }
        private static void PrintSet(IEnumerable<string> set)
        {
            foreach (string c in set)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();
        }

    }
}
