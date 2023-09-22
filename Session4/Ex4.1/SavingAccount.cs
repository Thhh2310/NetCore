using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1
{
    internal class SavingAccount: Account
    {
        private double Rate;
        public SavingAccount(double rate, double initialBalance):base(initialBalance)
        {
            Rate = rate;
        }
        public double GetInterest()
        {
            return Balance * (Rate / 100);
        }
    }
}
