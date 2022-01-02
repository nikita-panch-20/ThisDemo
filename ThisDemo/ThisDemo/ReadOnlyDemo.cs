using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisDemo
{

    class ReadOnlyDemo
    {
        const int x = 10; // CONSTANT SHOULD BE INITIATISED
        readonly int y;
        public ReadOnlyDemo()
        {
            y=100;
        }

        static void Main()
        {
            ReadOnlyDemo r = new ReadOnlyDemo();
            
            Console.WriteLine(r.y);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
