using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DemoApp
{
   public class TestClass
    {
        public void Add()
        {
            int i = 20;
            int j = 40;

            double d = i + j;
            Console.WriteLine("Sum =" + d);
            //Console.Read();
        }

        public void AvgValue()
        {
            int[] i = { 3, 4, 1, 2, 5 };
            var l = (from n in i
                     let m = i.Average()
                     where n < m
                     select m);

            foreach(var c in l)
            {
                Console.WriteLine("avg" + c);
            }

           // Console.Read();
        }

        public void Conversion()
        {
            int i = 76;
            char c = (char)i;
            Console.WriteLine(c);
            Console.Read();
        }
    }


    public class MyClass
    {
      public  void Show()
        {
            Console.WriteLine($"myclass show method");
        }
    }

    public class MyClass1 : MyClass
    {
      public  void Show()
        {
            Console.WriteLine("myclass1 show method");
        }
    }
}
