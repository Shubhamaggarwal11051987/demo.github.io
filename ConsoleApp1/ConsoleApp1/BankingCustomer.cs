using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BankingCustomer
    {
        public string ACNO { get; }
        public string Name;
        private double _Amount;

        public string Address { get; set; }
        public BankingCustomer(string acno,string name, double amt)
        {
            this.ACNO = acno;
            this.Name = name;
            this._Amount = amt;
        }

        public double Amount
        {
            get { return _Amount; }
            set
            {
                if (value > 1000)
                {
                    _Amount = value;
                }
                else
                {
                    Console.WriteLine("Insufficient amount, transaction failed !");
                }
            }
        }
    }
}
