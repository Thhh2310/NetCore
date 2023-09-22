using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1
{
    internal class Account
    {
        protected double Balance;
        public Account(double balance) 
        {
            Balance= balance;
        }
        public virtual void Desposit(double money)
        {
            if (money > 0)
            {
                Balance = money;
                Console.WriteLine("Deposit successful. Account: "+ money);
            }
            else
            {
                Console.WriteLine("Invalid deposit account");
            }
        }
        public virtual void WithDraw(double money) 
        { 
            if(money>0 && money <= Balance)
            {
                Balance = money;
                Console.WriteLine("WithDraw successful" + money);
            }
            else
            {
                Console.WriteLine("Invalid withdraw account");
            }
        }
        public double GetBalance()
        {
            return Balance;
        }
    }
}
