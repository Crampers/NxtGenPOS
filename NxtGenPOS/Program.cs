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
            ProductCatalog pc = new ProductCatalog();
            pc.AddProduct(50.00,"2kg Kale");
            CustomerCatalog cc = new CustomerCatalog();
            cc.AddCustomer("Test Test",0,1.05);
            Store s = new Store(pc,cc);
            Register r = s.Getregister();
            r.MakenewSale();
            r.EnterItem("2kg Kale",2);
            r.MakePayment(50);
            r.EndSale();
            r.PrintReceipt(0);
            Console.ReadKey();
        }
    }
}