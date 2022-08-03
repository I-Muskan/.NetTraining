using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo
{
    class Class1
    {
            public delegate void MyDelegate(string message);
            public event MyDelegate Banned;
            


        public void RaiseEvent(string message)
            {
                if (Banned != null) Banned(message);
            }
        }
    }

