using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    class Savings_Account : Account
    {

        

        public override string CloseAndReport()
        {
            if (totalOfWithdrawalThisMonth > 4)
                monthServiceCharge++;
            return base.CloseAndReport();
        }

        public override void MakeDeposit(double amount) 
        {
            bool active = Convert.ToBoolean(Status.active);
            bool inactive = Convert.ToBoolean(Status.inactive);

            if (active)
            {
                base.MakeDeposit(amount);
            }
            else if (inactive && starting_balance > 25)
            {
                inactive = active;
                base.MakeDeposit(amount);
            }
            else if (active && starting_balance < 25)
                active = inactive;
        }

        public override void MakeWithdrawl(double amount)
        {
            bool active = Convert.ToBoolean(Status.active);
            bool inactive = Convert.ToBoolean(Status.inactive);

            if (active)
            {
                base.MakeWithdrawl(amount);
            }
            else if (inactive){}
        }
    }
}
