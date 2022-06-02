using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private readonly string EGN;
        private Account account;

        public Person(string EGN, Account account)
        {
            this.EGN = EGN;
            this.account = account;
        }

        public void SendMoney(Account toAccount, int amount)
        {
            account.Amount -= amount;
            toAccount.Amount += amount;
        }
    }
}
