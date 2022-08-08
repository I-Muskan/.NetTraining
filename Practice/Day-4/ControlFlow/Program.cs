using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = 16;
            if(age<18)
            {
                Console.WriteLine("You are not allowed for ride");
            }
            else if(age==18)
            {
                Console.WriteLine("You are allowed for only 2 rides");
            }
            else
            {
                Console.WriteLine("Hurray! let's go on all the rides");
            }
        }
    }
}
