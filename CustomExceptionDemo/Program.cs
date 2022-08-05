using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            BankAccount userAcc = new BankAccount();
            Console.WriteLine("Enter Your account Number");
            userAcc.AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter Your Name");
            userAcc.Name = Console.ReadLine();
            userAcc.Balance = 8000;
            BankAccountServices userService = new BankAccountServices();





            Boolean flag = true;
            do
            {
                Menu();
                Console.WriteLine("please enter your choice");

                int choice = int.Parse(Console.ReadLine());
                Operate(choice,userAcc,userService);
            } while (flag);



        }
        static void Menu()
        {
            Console.WriteLine("press 1: To check balance");
            Console.WriteLine("press 2: to credit");

            Console.WriteLine("press 3: to debit");
            Console.WriteLine("4: EXIT");



        }
        static Boolean Operate(int choice,BankAccount userAcc,BankAccountServices userService)
        {

           

            switch (choice)
            {
                case 1:
                    

                    Console.WriteLine(userService.CheckBalance(userAcc));
                    return true;
                case 2:
                    userAcc.TransactionType = 'c';
                    Console.WriteLine("Enter Amount you want to credit");
                    userAcc.TransactionAmount = int.Parse(Console.ReadLine());
                    userService.MakeTransaction(userAcc,userAcc.TransactionType,userAcc.TransactionAmount);
                    return true;
                case 3:
                    userAcc.TransactionType = 'd';
                    Console.WriteLine("Enter Amount you want to debit");
                    userAcc.TransactionAmount = int.Parse(Console.ReadLine());
                    userService.MakeTransaction(userAcc, userAcc.TransactionType, userAcc.TransactionAmount);
                    return true;
                case 4:
                    return false;
                   
                default:
                    Console.WriteLine("Enter Correct Choice");
                    return false;

            }

        }
    }
}
    
