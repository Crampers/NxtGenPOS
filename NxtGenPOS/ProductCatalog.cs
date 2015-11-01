using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxtGenPOS
{
    class ProductCatalog
    {
        private List<ProductDescription> pcdList = new List<ProductDescription>();
        public ProductDescription GetProductDescription(int id)
        {
            return pcdList.Find(x => x.GetId() == id);
        }

        public void AddProduct(int id, double price, string desc)
        {
            pcdList.Add(new ProductDescription(id, price, desc));
        }
    }
}
