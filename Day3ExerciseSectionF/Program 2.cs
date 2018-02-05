using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionF
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phr = Console.ReadLine();
            
                for(int i = 0; i < phr.Length/2; i++)
                {
                    if (phr.Substring(i, 1) != phr.Substring(phr.Length - i - 1, 1))
                    {
                        Console.WriteLine("{0} is Not a Palindrome", phr);
                        return;
                    }
                }
            
            Console.WriteLine("{0} is a Palindrome", phr);
        }
    }
}
