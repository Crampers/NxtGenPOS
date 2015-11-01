using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxtGenPOS
{
    class Payment
    {
        private readonly double _amount;
        public Payment(double cashTendered)
        {
            _amount = cashTendered;
        }

        public double GetAmount()
        {
            return _amount;
        }
    }
}
