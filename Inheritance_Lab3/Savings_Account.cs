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
        //ok
        public Savings_Account(double sb, double annualRate) : base(sb, annualRate)
        {
            starting_balance = sb;
            annualInterestRate = annualRate;
        }

        //ok
        public override string CloseAndReport()
        {
            if (numberOfWithdrawal > 4)
                monthServiceCharge++;  
            return base.CloseAndReport();
        }

        //problem
        public override void MakeDeposit(double amount) 
        {
            Enum valid = Status.active;
        
            if(starting_balance > 0)
                base.MakeDeposit(amount);
        }

        //problem
        public override void MakeWithdraw(double amount)
        {
            bool active = Convert.ToBoolean(Status.active);

            if (active)
            {
                base.MakeWithdraw(amount);
            }
           
        }
    }
}
