using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MyStatic
    {

        public static int Count { get; set; } = 0;

        public MyStatic()
        {
            Count = Count + 1;
        }

        

        public static void Test()
        {
            
            Console.WriteLine("I am Test method...");
        }

        public void Test2()
        {
            //Test();
            Console.WriteLine("I am Non static member");
        }
    }
}
