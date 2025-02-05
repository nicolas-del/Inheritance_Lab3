﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    class GlobalSavingsAccount : Savings_Account, IExchangeable
    {
        
        public GlobalSavingsAccount(double sb, double annualRate) : base(sb, annualRate)
        {
            starting_balance = sb;
            annualInterestRate = annualRate;
        }

        
        public double USValue(double rate)
        {
            return starting_balance * rate;
        }
    }
}
