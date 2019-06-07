using System;
using Algo;
using Fibonacci;
namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = (int)EnumValues.customerParent;
            int j = (int)EnumValues.customer;
            Console.WriteLine(i + j);

            MyClass1 m = new MyClass1();
            m.Show(); // class1
            MyClass m1 = new MyClass1();
            m1.Show(); // class1
            Console.Read();

        }
    }
}
