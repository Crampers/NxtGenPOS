using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxtGenPOS
{
    class SalesLineItem
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
}
