using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxtGenPOS
{
    internal class Register
    {
        private Sale s;
        private readonly ProductCatalog pc;
        private readonly CustomerCatalog cc;

        public Register(ProductCatalog pc, CustomerCatalog cc)
        {
            this.pc = pc;
            this.cc = cc;
        }

        public void MakenewSale(int id)
        {
            s = new Sale(cc.GetCustomerDescription(id));
        }

        public void MakePayment(int cash)
        {
            s.MakeNewPayment(cash);
        }

        public void EnterItem(string desc, int qty)
        {
            s.MakeLineItem(pc.GetProductDescription(desc),qty);
        }

        public void EndSale()
        {
            s.BecomeComplete();
        }

        public void PrintReceipt(int id)
        {
            Console.WriteLine("\n----------------Receipt----------------");
            Console.WriteLine("\nName of Buyer: " + cc.GetCustomerDescription(id).GetName());
            Console.WriteLine("Item's bought:");
            foreach (var V in s.SalesLine())
            {
                Console.WriteLine("\n"+V.GetPcd().GetDesc()+"\tQuantity: "+V.GetQty());
            }
            Console.WriteLine("\nBuyer's Discount: %" + cc.GetCustomerDescription(id).GetRabat());
            Console.WriteLine("\nTotal of Sale: {0:F2}Kr", s.GetTotal());
            Console.WriteLine("With Discount: {0:F2}Kr", (s.GetTotal() / cc.GetCustomerDescription(id).GetRabat()));
            Console.WriteLine("\nTotal of Sale after VAT: {0:F2}Kr", ((s.GetTotal() / cc.GetCustomerDescription(id).GetRabat())*1.25));
            Console.WriteLine("\n------------------END------------------");
        }
    }
}