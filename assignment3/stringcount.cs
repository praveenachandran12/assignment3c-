using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class stringcount
    {

        public static void Main(string[] args)
        {
            string str = "Weclom to the tutorial";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    count++;
            }

            Console.WriteLine("String :" + str);
            Console.Write("Number of spaces = " + count);
            Console.ReadLine();
        }
    }
}
