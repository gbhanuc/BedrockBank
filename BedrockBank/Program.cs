using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of an acount==creating an object. 
            var account = new Account();
            //account.AccountNumber=123;
            account.Name = "Bhanu Checking";
            account.Deposit(500);
            Console.WriteLine("Name: {0}, AccountNumber: {1}, Balance {2}", account.Name,account.AccountNumber, account.Balance);
            var savingsAccount = new Account();
            savingsAccount.Name = "Bhanu savings";
            savingsAccount.Deposit(15000);
            //exception handling
            try
            {

                savingsAccount.withdraw(16000);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("OOps something went wrong {0}",ex.Message);
            }
            Console.WriteLine("Name: {0}, AccountNumber: {1}, Balance {2}", savingsAccount.Name, savingsAccount.AccountNumber, savingsAccount.Balance);
        }
    }
}
