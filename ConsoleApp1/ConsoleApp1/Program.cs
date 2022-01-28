using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee em = new Employee("Ajay", "Singh", 120000);
            var em2 = new Employee(em);
            Console.WriteLine(em.GetFullName());
            Console.WriteLine(em.CalculateMonthalySalary());

            em.AnualSalary = 250000;
            Console.WriteLine("----------------------------");
            Console.WriteLine(em.GetFullName());
            Console.WriteLine(em.CalculateMonthalySalary());

            // i want old salary
            Console.WriteLine(em2.GetFullName());
            Console.WriteLine(em2.CalculateMonthalySalary());
            */

            // TestClass obj = new TestClass();
            // TestClass.Test();

            //MyStatic.Test();


            // var cust = new BankingCustomer("SBI0091","DEEPAK",12000);
            // Console.WriteLine("----------Customer record--------");
            // Console.WriteLine("Account NO:  "+cust.ACNO);
            // Console.WriteLine("Name: "+cust.Name);
            // Console.WriteLine("Amount: "+cust.Amount);

            //// cust.ACNO = "sefawerwe";
            // cust.Amount -= 10000;


            // Console.WriteLine("----------Customer record after modify--------");
            // Console.WriteLine("Account NO:  " + cust.ACNO);
            // Console.WriteLine("Name: " + cust.Name);
            // Console.WriteLine("Amount: " + cust.Amount);


            //MyStatic obj1 = new MyStatic();
            //MyStatic obj2 = new MyStatic();
            //MyStatic obj3 = new MyStatic();


            //Console.WriteLine(MyStatic.Count);

            // MyStatic.Test();

            // FulltimeEmployee emp = new FulltimeEmployee();
            // emp.


            //  ParttimeEmployee pemp = new ParttimeEmployee();

            //var o = new XYZ("Welcome message");
            //o.PrintMessage();


            //var O = new TestClass2();
            //O.PrintMessage();

            var Emp = new FulltimeEmployee() { Id = 1, FirstName = "Rajeev", LastName = "Verma", AnualSalary = 120000 };
            Console.WriteLine(Emp.GetFullName());
            Console.WriteLine(Emp.GetSalary());
        }
    }
}
