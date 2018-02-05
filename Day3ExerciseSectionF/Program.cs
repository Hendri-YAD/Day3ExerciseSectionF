using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phr = Console.ReadLine();
            phr = phr.ToUpper();
            string s;
            int a=0, e = 0, i = 0, o = 0, u = 0;

            for (int j=0; j<phr.Length; j++)
            {
                s = phr.Substring(j, 1);

                switch (s)
                {
                    case "A":
                        a++;
                        break;
                    case "E":
                        e++;
                        break;
                    case "I":
                        i++;
                        break;
                    case "O":
                        o++;
                        break;
                    case "U":
                        u++;
                        break;
                    default:
                        break;
                }

            }

            int total = a + e + i + o + u;

            Console.WriteLine("Total vowels: {0}", total);
            Console.WriteLine("A: {0}", a);
            Console.WriteLine("E: {0}", e);
            Console.WriteLine("I: {0}", i);
            Console.WriteLine("O: {0}", o);
            Console.WriteLine("U: {0}", u);

        }
    }
}
