using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxtGenPOS
{
    class CustomerCatalog
    {
        private List<CustomerDescription> cList = new List<CustomerDescription>();

        public CustomerDescription GetCustomerDescription(int id)
        {
            return cList.Find(x => x.GetKundeNr() == id);
        }

        public void AddCustomer(string name, int kundeNr, double rabat)
        {
            cList.Add(new CustomerDescription(name, kundeNr, rabat));
        }
    }
}
