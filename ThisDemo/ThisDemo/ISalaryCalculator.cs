using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisDemo
{
    interface ITaxCalculator
    {
        // IF A CLASS WANTS TO INHERIT A CLASS AND AN INTERACE, THEN FIRST INHERIT THE CLASS AND THEN THE INTERFACE.
        // ANY INTERFACE WILL EXPOSE OR EXECUTE ONLY THOSE METHODS WHICH IT HAS IN IT.
        // BY DEFAULT ALL METHODS ARE PUBLIC AND ABSTRACT
         double CalculateTax(double basic);
    }
    
}
