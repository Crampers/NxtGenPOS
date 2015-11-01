using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxtGenPOS
{
    class CustomerDescription
    {
        private string name;
        private int kundeNr;
        private double rabat;

        public CustomerDescription(string name, int kundeNr, double rabat)
        {
            this.name = name;
            this.kundeNr = kundeNr;
            this.rabat = rabat;
        }

        public int GetKundeNr()
        {
            return kundeNr;
        }

        public string GetName()
        {
            return name;
        }

        public double GetRabat()
        {
            return rabat;
        }

    }
}
