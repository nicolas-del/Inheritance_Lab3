using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    class GlobalSavingsAccount : SavingsAccount, IExchangeable
    {
        public double USValue(double rate)
        {
            return current_balance * rate;
        }
    }
}
