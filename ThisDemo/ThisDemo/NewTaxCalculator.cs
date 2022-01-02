using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisDemo
{
    class NewTaxCalculator: ITaxCalculator
    {
        public double CalculateTax(double basic)
        {
            double tax = 0;
            double taxAmount = basic;
            if (basic < 50000)
            {
                tax = basic - (basic * 5) / 100;
                taxAmount = taxAmount - tax;
            }
            if (taxAmount < 750000)
            {
                tax = basic - (basic * 20) / 100;
                taxAmount = taxAmount - tax;

            }
            if (taxAmount < 1000000)
            {
                tax = basic - (basic * 30) / 100;
                taxAmount = taxAmount - tax;

            }
            if (taxAmount < 1200000)
            {
                tax = basic - (basic * 30) / 100;
                taxAmount = taxAmount - tax;

            }
            if (taxAmount < 1500000)
            {
                tax = basic - (basic * 10) / 100;
                taxAmount = taxAmount - tax;

            }
            if (taxAmount > 1500000)
            {
                tax = basic - (basic * 25) / 100;
                taxAmount = taxAmount - tax;


            }

            return tax;
        }
    }
}
