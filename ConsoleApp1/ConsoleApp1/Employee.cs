using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public virtual double GetSalary()
        {
            return 0;
        }


    }
}
