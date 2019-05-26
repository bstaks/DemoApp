/*https://www.hackerearth.com/practice/basic-programming/recursion/recursion-and-backtracking/practice-problems/algorithm/gcd-strings/ */

using System;
using System.IO;

public class GCDString
{
    public void GetGCD()
    {
        int testCase = Convert.ToInt32(Console.ReadLine());
        string inputNumber = "";
        for (int index = 0; index < testCase; index++)
        {
            inputNumber = Console.ReadLine();
        }

        for (int index = 0; index < inputNumber.Length; index++)
        {
            string[] inputNumber1 = inputNumber.Split(' ');
            long binaryNumber = SetBinaryNumber(Convert.ToInt64(inputNumber1[0])
            , Convert.ToInt64(inputNumber1[1]));
            Console.WriteLine(BinaryNumber(binaryNumber));
        }

    }
    long zeroValue = 0;
    private long SetBinaryNumber(long a, long b)
    {
        if (a % b == 0)
        {
            zeroValue = a - 1;
           // BinaryNumber();
        }

        return 0;
    }

    string tempValue = "";
    private long BinaryNumber(long loop)
    {
        while (loop > 0)
        {
            tempValue += "1" + Math.Pow(10, zeroValue).ToString();
            loop--;
            BinaryNumber(loop);
        }
        return 0;

    }
}