using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TestClass
    {
        public virtual void PrintMessage()
        {
            Console.WriteLine("Welcome- I am from Test Class---");
        }
    }

    class TestClass2 : TestClass
    {

        public new void PrintMessage()
        {
            Console.WriteLine("Hi- I am from Class-2....");
        }
    }
}
