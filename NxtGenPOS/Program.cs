using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxtGenPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class ProductCatalog
    {
         
    }

    class Register
    {
        private readonly Sale s = new Sale();
        public void makeLineItem(int quantity)
        {
            s.makeLineItem(quantity);
        }
    }

    class Sale
    {
        private readonly SalesLineItem sl = new SalesLineItem();
        private readonly Payment p = new Payment();

        public void makePayment(double cashTendered)
        {
            p.create(cashTendered);
        }

        public void makeLineItem(int quantity)
        {
            sl.create(quantity);
        }
    }

    class Payment
    {
        public void create(double cashTendered)
        {

        }
    }

    class SalesLineItem
    {
        public void create(int quantity)
        {
            
        }
    }
}
