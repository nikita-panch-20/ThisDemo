using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisDemo
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public int employeeId { get; set; }
        public Employee(int employeeId)
        {

            this.employeeId = employeeId;
        }

        public Employee()
        {
            
            Console.WriteLine("Const of Employee");
        }
    }
    class Manager : Employee {
        public double salary { get; set; }
        public Manager(int employeeId)
            : base(employeeId)
        {
            Console.WriteLine("Const of Manager");
        }
    }
    class InhDemo1
    {
        static void Main() {
            Manager m = new Manager(10);
            Console.ReadLine();
        }

    }
}
