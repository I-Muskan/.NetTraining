using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomExceptionDemo
{
    public class CheckBalanceException : Exception
    {

        public override string Message
        {
            get
            {
                return "Your Balance is less than 500 You can not make this transaction";
            }
        }
    }
    class BankAccountServices
    {
        public double CheckBalance(BankAccount userAcc)
        {
            return userAcc.Balance;
        }
        public void MakeTransaction(BankAccount userAcc,char transtype,int transAmount)
        {
            char type=userAcc.TransactionType;
            int amt = userAcc.TransactionAmount;
            switch (type)
            {
                case 'd':
                  
                    
                        if (amt > userAcc.Balance && userAcc.Balance>=500)
                        {
                            Console.WriteLine("Your balance is less than entered amount ");
                            CheckBalance(userAcc);
                        break;
                        }
                    if (userAcc.Balance > 500)
                    {
                        userAcc.Balance -= amt;
                        Console.WriteLine("Your account is debited by {0} , Available Balnce is {1}", userAcc.TransactionAmount, userAcc.Balance);
                    }


                    try
                    {
                        if (userAcc.Balance < 500)
                        {
                            throw new CheckBalanceException();
                        }
                    }
                    catch (CheckBalanceException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    


                    break;
                case 'c':
                    userAcc.Balance += amt;
                    Console.WriteLine("Your account is credited by {0} , Available Balnce is {1}", userAcc.TransactionAmount, userAcc.Balance);
                    
                    break;
                default:
                    Console.WriteLine("Please Enter correct input either 'c' for credit or 'd' for debit");
                    break;
            }
            
            
        }
    }
}
