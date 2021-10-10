using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();
            string[] a = s.Split(new Char[] { ' ' });
            int max = 0;
            int word = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > max)
                {
                    max = a[i].Length;
                    word = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", a[word]);
            Console.ReadKey();



        }
    }
}
