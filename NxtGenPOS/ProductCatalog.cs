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
        private int id = 0;
        public ProductDescription GetProductDescription(string desc)
        {
            return pcdList.Find(x => x.GetDesc() == desc);
        }

        public void AddProduct(double price, string desc)
        {
            pcdList.Add(new ProductDescription(id, price, desc));
            Console.WriteLine("Product was created\n Product ID: "+pcdList[id].GetId() + "\t Product Price: " + pcdList[id].GetPrice()+"\t Product Name: "+pcdList[id].GetDesc());
        }
    }
}
