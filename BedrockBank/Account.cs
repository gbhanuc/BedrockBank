﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    /// <summary>
    /// This class provides definition for a Bedrock Bank
    /// </summary>
    class Account
    {
        #region variables
        //shared memory for storing last account number
        private static int lastAccountNumber=0;
        #endregion
        #region properties
        /// <summary>
        /// Name of the account holder
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Account number  for the account
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        /// Account Balance for the account
        /// </summary>
        public decimal Balance { get; private set; }
        #endregion

        #region constructor
        public Account()
        {
            AccountNumber=++lastAccountNumber;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Money to deposit</param>
        /// <returns>New balance</returns>
        public decimal Deposit(decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
            return Balance;
        }
    
        public decimal withdraw(decimal amount)
        {
            
            if (amount>Balance)
            {
                throw new ArgumentException("Insufficient Funds");
            }
            Balance -= amount;
            return Balance;
        }
        #endregion
    }
}
