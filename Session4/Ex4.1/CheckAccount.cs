using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1
{
    internal class CheckAccount: Account
    {
        private double FeeTransfer;
        public CheckAccount(double feeTransfer, double balance): base(balance)
        {
            this.FeeTransfer = feeTransfer;
        }
        public override void Desposit(double money)
        {
            base.Desposit(money);
        }
        public override void WithDraw(double money)
        {
            base.WithDraw(money);
        }
    }
}
