using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public static class BankFactory
    {
        public static Account CreateAccount(string name, int SSN)
        {
            var account = new Account(name);
            account.SSN = SSN;
            return account;
        }
        public static Account CreateAccount(string name, int SSN, decimal amount)
        {
            //var account = CreateAccount(name);
            var account = new Account(name, amount);
            account.SSN = SSN;
            //account.Name = name;
            //account.Deposit(amount);
            return account;
        }
    }
}
