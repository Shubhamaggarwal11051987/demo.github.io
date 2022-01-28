using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FulltimeEmployee : Employee
    {
        public double AnualSalary { get; set; }

        public new double GetSalary()
        {
            return this.AnualSalary / 12;
        }
    }
}
