using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "текст{потом еще {опять текст} снова какой-то текст} и еще немного текста";
            Console.WriteLine(str);
            char s1 = '{';
            char s2 = '}';
            int indexOfS1 = str.IndexOf(s1); 

            int indexOfS2 = str.LastIndexOf(s2);

            int A = indexOfS2 + 1 - indexOfS1;

            Console.WriteLine();
            string str2 = str.Remove(indexOfS1, A);
            Console.WriteLine(str2);


            Console.ReadKey();
        }
    }
}
