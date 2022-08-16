using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class DelegateExercise
    {
        public delegate void MyDelagate(int i);
        public void Method1(int i)
        {
            Console.WriteLine("This is Method 1 th i is: "+i);
        }
        public void Method3()
        {
            Console.WriteLine("This is Method 3");
        }
        public void Method2()
        {
           
            MyDelagate mydelObj = new MyDelagate(Method1);
            mydelObj(50);

        }
    }
}
