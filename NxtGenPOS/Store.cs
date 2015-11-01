using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxtGenPOS
{
    class Store
    {
        private string address;
        private readonly Register r = new Register(new ProductCatalog(), new CustomerCatalog());

        public Register Getregister()
        {
            return r;
        }
    }
}
