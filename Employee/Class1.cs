using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Employee
{
   
 
        public class Employee
        {
            private int id, salary;
            private String name;

            public void Add(int id,string name,int salary)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;

            }
            public String Print()
            {
                return $"Employee:{id}/{name}/{salary}";
            }
        }
    
}
