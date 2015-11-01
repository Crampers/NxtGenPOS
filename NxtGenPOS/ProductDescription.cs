using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxtGenPOS
{
    class ProductDescription
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
}
