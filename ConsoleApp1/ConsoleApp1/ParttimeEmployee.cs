
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ParttimeEmployee:Employee
    {
        public double PerhourSalary { get; set; }
        public int TotalWorkingHour { get; set; }

        //public new double GetSalary()
        //{
        //    return PerhourSalary*(TotalWorkingHour);
        //}
    }
}
