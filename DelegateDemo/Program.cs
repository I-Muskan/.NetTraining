using System;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            userName = Console.ReadLine();
            if(userName.Equals("ram", StringComparison.InvariantCultureIgnoreCase) || userName.Equals("shyam", StringComparison.InvariantCultureIgnoreCase) || userName.Equals("naveen", StringComparison.InvariantCultureIgnoreCase))
            {
                Class1 myClass1 = new Class1();
                myClass1.Banned += new Class1.MyDelegate(Class1_Banned);
                Console.WriteLine("Alarm:  \n");
      
                
                  myClass1.RaiseEvent(userName);
                Console.Read();
            }
            else
            {
                Console.WriteLine("Welcome to the class {0} ",userName);
            }
            static void Class1_Banned(string name)
            {
                Console.WriteLine("Banned student trying to join : {0}", name);
                Console.WriteLine("Mail to admistration sent");
            }
           

        }
    }
}
