using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();
            s = s.ToLower();
            s = s.Replace(" ", "");
            int A = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == s[s.Length - i - 1])
                {
                    A = A += 1;
                }

            }

            if (A == s.Length)
            {
                Console.WriteLine("предложение палиндром");
            }
            else
            {
                Console.WriteLine("предложение не палиндром");
            }

            Console.ReadKey();

        }
    }
}
