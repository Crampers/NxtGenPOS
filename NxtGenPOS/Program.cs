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
            //
        }
    }

    class ProductCatalog //Done
    {
        private List<ProductDescription> pcdList = new List<ProductDescription>();
        public ProductDescription getProductDescription(int id)
        {
            return pcdList.Find(x => x.getID() == id);
        }
    }

    class Register //Done
    {
        private Sale s;
        private readonly ProductCatalog pc;
        public Register(ProductCatalog pc)
        {
            this.pc = pc;
        }

        public void newSale()
        {
            s = new Sale();
        }

        public void makePayment(int cash)
        {
            s.makeNewPayment(cash);
        }

        public void enterItem(int id, int qty)
        {
            ProductDescription desc = pc.getProductDescription(id);
            s.makeLineItem(desc, qty);
        }

        public void endSale()
        {
            s.becomeComplete();
        }

    }

    class Sale //Done
    {
        private List<SalesLineItem> slItem = new List<SalesLineItem>();
        private Payment p;
        private bool _isComplete = false;
        private string _Date;

        public double getBalance()
        {
            return p.getAmount() - getTotal();
        }

        public void makeLineItem(ProductDescription desc, int qty)
        {
            slItem.Add(new SalesLineItem(desc, qty));
        }

        public double getTotal()
        {
            double total = 0;
            foreach (var sl in slItem)
            {
                var subtotal = sl.getSubtotal();
                total = total + subtotal;
            }
            return total;
        }
        public void becomeComplete()
        {
            _isComplete = true;
        }

        public bool Complete()
        {
            return _isComplete;
        }

        public void makeNewPayment(double cashTendered)
        {
            p = new Payment(cashTendered);
        }


    }

    class Payment // Done
    {
        private readonly double amount;
        public Payment(double cashTendered)
        {
            amount = cashTendered;
        }

        public double getAmount()
        {
            return amount;
        }
    }

    class SalesLineItem //Done
    {
        private int qty;
        private ProductDescription pcd;
        public SalesLineItem(ProductDescription pcd, int qty)
        {
            this.qty = qty;
            this.pcd = pcd;
        }
        public double getSubtotal()
        {
            return pcd.getPrice();
        }
    }

    class ProductDescription //Done
    {
        private int id;
        private double price;
        private string desc; // desc = description

        public ProductDescription(int id, double price, string desc)
        {
            this.id = id;
            this.price = price;
            this.desc = desc;
        }

        public double getPrice()
        {
            return price;
        }

        public int getID()
        {
            return id;
        }

        public string getDesc()
        {
            return desc;
        }
    }

    class Store //Done
    {
        private string adress;
        private readonly Register r = new Register(new ProductCatalog());

        public Register getregister()
        {
            return r;
        }
    }

    class CustomerDescription
    {
        private string name;
        private int kundeNr;
        private double rabat;

        public int getKundeNr()
        {
            return kundeNr;
        }

        public string getName()
        {
            return name;
        }

        public double getRabat()
        {
            return rabat;
        }

    }

    class CustomerCatalog
    {
        private List<CustomerDescription> cList = new List<CustomerDescription>();

        public CustomerDescription getCustomerDescription(int id)
        {
            return cList.Find(x => x.getKundeNr() == id);
        }
    }
}