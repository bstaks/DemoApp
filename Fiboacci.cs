

using System;
namespace Fibonacci
{
    public class FibonacciSeries
    {

        public void Fibonacci(int n, int a, int b)
        {
            if (n == 1) return;
            else
            {
                int c = 0;
                c = a;
                a = a + b;
                Console.WriteLine($"{a}");
                b = c;
                Fibonacci(n - 1, a, b);
            }
        }
    }
}