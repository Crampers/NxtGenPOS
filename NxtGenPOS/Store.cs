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
        private readonly Register r;

        public Store(ProductCatalog pc, CustomerCatalog cc)
        {
            r = new Register(pc,cc);
        }

        public Register Getregister()
        {
            return r;
        }
    }
}
