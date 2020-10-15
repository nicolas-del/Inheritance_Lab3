using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    class StringAndNegativeNotAllowedException : Exception
    {
        private double number;

        public StringAndNegativeNotAllowedException() { }
        public StringAndNegativeNotAllowedException(string message): base(message) 
        {}

        public override string Message 
        {   get 
            {
                return string.Format("Error: the number you entered is negative");
            }
        }

        public void CheckForNegative(double number) 
        {
            if (number < 0)
                throw new StringAndNegativeNotAllowedException("Error: the number you entered is negative");
        }

    }
}
