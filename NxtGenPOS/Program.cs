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
        public ProductDescription GetProductDescription(int id)
        {
            return pcdList.Find(x => x.GetId() == id);
        }
    }

    class Register //Done
    {
        private Sale s;
        private readonly ProductCatalog pc;
        private readonly CustomerCatalog cc;
        public Register(ProductCatalog pc,CustomerCatalog cc)
        {
            this.pc = pc;
            this.cc = cc;
        }

        public void MakenewSale()
        {
            s = new Sale();
        }

        public void MakePayment(int cash)
        {
            s.MakeNewPayment(cash);
        }

        public void EnterItem(int id, int qty)
        {
            ProductDescription desc = pc.GetProductDescription(id);
            s.MakeLineItem(desc, qty);
        }

        public void EndSale()
        {
            s.BecomeComplete();
        }

    }

    class Sale //Done
    {
        private List<SalesLineItem> slItem = new List<SalesLineItem>();
        private Payment p;
        private bool _isComplete = false;
        private string _Date;

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


    }

    class Payment // Done
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

    class SalesLineItem //Done
    {
        private int qty;
        private ProductDescription pcd;
        public SalesLineItem(ProductDescription pcd, int qty)
        {
            this.qty = qty;
            this.pcd = pcd;
        }
        public double GetSubtotal()
        {
            return pcd.GetPrice();
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

        public double GetPrice()
        {
            return price;
        }

        public int GetId()
        {
            return id;
        }

        public string GetDesc()
        {
            return desc;
        }
    }

    class Store //Done
    {
        private string address;
        private readonly Register r = new Register(new ProductCatalog(),new CustomerCatalog());

        public Register Getregister()
        {
            return r;
        }
    }

    class CustomerDescription
    {
        private string name;
        private int kundeNr;
        private double rabat;

        public CustomerDescription(string name, int kundeNr, double rabat)
        {
            this.name = name;
            this.kundeNr = kundeNr;
            this.rabat = rabat;
        }

        public int GetKundeNr()
        {
            return kundeNr;
        }

        public string GetName()
        {
            return name;
        }

        public double GetRabat()
        {
            return rabat;
        }

    }

    class CustomerCatalog
    {
        private List<CustomerDescription> cList = new List<CustomerDescription>();

        public CustomerDescription GetCustomerDescription(int id)
        {
            return cList.Find(x => x.GetKundeNr() == id);
        }
    }
}