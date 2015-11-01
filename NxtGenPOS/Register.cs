using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxtGenPOS
{
    class Register 
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

        public void PrintRecipe(int id)
        {
            Console.WriteLine("Name of Buyer: " +cc.GetCustomerDescription(id).GetName());
            Console.WriteLine("Item's bought:");
            foreach (var V in s.SalesLine())
            {
                Console.WriteLine(V);
            }
            Console.WriteLine("Buyer's Discount: " +cc.GetCustomerDescription(id).GetRabat());
            Console.WriteLine("Total of Sale: " +s.GetTotal());
            Console.WriteLine("Total of Sale after VAT: " +s.GetTotal());
        }
}
