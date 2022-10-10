using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Add(122,"joe",20000);
            Console.WriteLine(e1.Print());

            Employee e2 = new Employee();
            e2.Add(123, "john", 25000);
            Console.WriteLine(e2.Print());

        }
    }
}
