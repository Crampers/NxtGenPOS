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
            //Test
            ProductCatalog pc = new ProductCatalog();
            pc.AddProduct(50.00,"2kg Kale"); //Test item
            CustomerCatalog cc = new CustomerCatalog();
            cc.AddCustomer("Test Test",0,1.05); //Test Costumer
            Store s = new Store(pc,cc);
            Register r = s.Getregister();
            r.MakenewSale(0); //Makes Costumer the "owner" of the sale ie. the items bought
            r.EnterItem("2kg Kale",2);
            r.MakePayment(50);
            r.EndSale();
            r.PrintReceipt(0);
            Console.ReadKey();
        }
    }
}