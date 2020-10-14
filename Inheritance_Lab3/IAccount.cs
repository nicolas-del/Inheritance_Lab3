using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    interface IAccount
    {
        void MakeWithdraw(double amount);
        void MakeDeposit(double amount);
        void CalculateInterest();
        string CloseAndReport();
    }
}
