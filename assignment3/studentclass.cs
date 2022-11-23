using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class studentclass
    {
        public int rollNumber;
        public string name;

        public studentclass()
        {
            rollNumber = 208765;
            name = "maya";
        }
        public void Displaydetails()
        {
            Console.WriteLine($"Rollnumber is {rollNumber} \n Name is {name}");
        }
    }
      public class test
        {
            static void Main(string[] args)
            {
                studentclass r = new studentclass();
                r.Displaydetails();
            }
        }
    
}