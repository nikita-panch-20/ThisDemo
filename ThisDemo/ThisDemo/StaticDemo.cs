using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisDemo
{
    class StaticDemo

    {//static members CAN BE ACCESSED by Non static member; NON Static member CANNOT BE ACCESSED by a staic member.
        static int x;// a static member can be accessed by all the objecs of that class, also called as class member; all objects have a same static member.
        int y;// instance member : each object has a different copy of these instance member
        public void Show() {
            int z = 0;// local member
            x++;
            y++;
            z++;
            Console.WriteLine($"X={x} \t Y={y} \tZ={z}");
        }
        static StaticDemo() {
            // STATIC MEMBERS ARE ALWAYS CALLED ONCE IRRESPECTIVE OF ANY NO> OF OBJECTS OF THAT CLASS
            x = 100;
            Console.WriteLine("Static Const 0 para");
        }
        public StaticDemo() {
            Console.WriteLine("Const with 0 para ");
        }
        static void Main() {
            Console.WriteLine("Main called");
            StaticDemo st1 = new StaticDemo();
            StaticDemo st2 = new StaticDemo();
            st1.Show();
            st2.Show();
            st1.Show();
            st2.Show();
            Console.ReadLine();

        }
    }
}
