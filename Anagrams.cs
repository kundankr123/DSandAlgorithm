using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgorithmProblems
{
    public class Anagrams
    {
        public void Display()
        {
            Console.WriteLine("Enter First String");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            string str2 = Console.ReadLine();

            char[] ch1 = str1.ToUpper().ToCharArray();
            char[] ch2 = str2.ToUpper().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("They are Anagrams!");
            }
            else
            {
                Console.WriteLine("Not Anagrams!");
            }
        }
    }
}
