using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ABC
    {
        public string Message { get; set; }
        public ABC(string msg)
        {
            Message = msg;
        }
    }
    class XYZ : ABC
    {
       // public string Message { get; set; } = "Welcome to XYZ class";

        public XYZ(string msg):base(msg) { }

        public void PrintMessage()
        {
            Console.WriteLine(base.Message);
        }
    }
}
