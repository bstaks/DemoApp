using System;
namespace DemoApp
{
class A
{
    static A()
    {
        Console.WriteLine($"static constructor call A");
    }

    public A()
    {
        Console.WriteLine($"detfault constructor call A");
    }
}

class B : A
{
 static B()
    {
        Console.WriteLine($"static constructor call B");
    }

    public B()
    {
        Console.WriteLine($"detfault constructor call B");
    }
}
}