using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisDemo
{
    class This
    {
        int num1;
        int num2;
        int num3;
        public This() {
            Console.WriteLine("Const with 0 paraameter");
        }
        public This(int num1) {
            this.num1 = num1;
            Console.WriteLine("Const with 1 para");
        }
        public This(int num1, int num2, int num3) {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;

        }

        public This(int num1,int num2) : this(num1) { 
            this.num1 = num1;
            this.num2 = num2;
        }
        public void Display() {
            Console.WriteLine($"No1={num1} \t No2={num2}");
            Console.WriteLine($"Object:{this}");
            

        }
        static void Main(string[] args)
        {
            This t = new This(10, 20, 30);
            This t1 = new This();
            This t2 = new This(10);
            This t3 = new This(10, 20);
            t.Display();
            t1.Display();
            t2.Display();
            t3.Display();
            Console.ReadLine();

                  
        }
    }
}
