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

        public void makePayment()
        {
            s.addPayment();
        }
    }

    class Sale
    {
        private readonly SalesLineItem sl = new SalesLineItem();
        private readonly Payment p = new Payment();

        public void makePayment()
        {
            p.create();
        }

        public void makeLineItem(int quantity)
        {
            sl.create(quantity);
        }

        public void addPayment()
        {
            p.create();
        }
    }

    class Payment
    {
        public void create()
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
