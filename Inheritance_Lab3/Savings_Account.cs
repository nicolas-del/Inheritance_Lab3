﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    internal class Savings_Account : Account
    {

        public Savings_Account(double sb, double annualRate) : base(sb, annualRate)
        {
            starting_balance = sb;
            annualInterestRate = annualRate;
        }

        
        public override string CloseAndReport()
        {
            if (numberOfWithdrawal > 4)
                monthServiceCharge++;  
            return base.CloseAndReport();
        }

        
        public override void MakeDeposit(double amount) 
        {
            base.MakeDeposit(amount);
            if (stat == Status.inactive && starting_balance >= 25)
                stat = Status.active;
            else if (stat == Status.active && starting_balance < 25)
                stat = Status.inactive;
        }

        
        public override void MakeWithdraw(double amount)
        {
            if (stat == Status.active)
            {
                base.MakeWithdraw(amount);
            }
            else if(stat == Status.inactive) 
            {
                throw new Exception();
            }
        }
    }
}
