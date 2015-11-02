using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxtGenPOS
{
    class Sale
    {
        private List<SalesLineItem> slItem = new List<SalesLineItem>();
        private Payment p;
        private bool _isComplete = false;
        private string _Date;
        private int id;

        public Sale(CustomerDescription cd)
        {
            id = cd.GetKundeNr();
        }

        public double GetBalance()
        {
            return p.GetAmount() - GetTotal();
        }

        public void MakeLineItem(ProductDescription desc, int qty)
        {
            slItem.Add(new SalesLineItem(desc, qty));
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (var sl in slItem)
            {
                var subtotal = sl.GetSubtotal();
                total = total + subtotal;
            }
            return total;
        }
        public void BecomeComplete()
        {
            _isComplete = true;
        }

        public bool Complete()
        {
            return _isComplete;
        }

        public void MakeNewPayment(double cashTendered)
        {
            p = new Payment(cashTendered);
        }

        public List<SalesLineItem> SalesLine()
        {
            return slItem;
        }


    }
}
