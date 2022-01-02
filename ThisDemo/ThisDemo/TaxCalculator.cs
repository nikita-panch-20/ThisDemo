using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisDemo
{
    class TaxCalculator
    {
        static void Main() {
            bool isOldTax = true;
            double amt = 260000;
            OldTextCalculator old = new OldTextCalculator();
            NewTaxCalculator newTax = new NewTaxCalculator();
            if (isOldTax)
            {
                Console.WriteLine($"Old Tax Value is {CalculateTax(old, amt)}");
            }
            else {
                Console.WriteLine($"New Tax Value is {CalculateTax(newTax, amt)}");

            }
        }
        public static double CalculateTax(ITaxCalculator taxCalculator, double amt) {
            return taxCalculator.CalculateTax(amt);
        }
    }
}
