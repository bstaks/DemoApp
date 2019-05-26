
using System;

public class Region
{
    public void GetRegion()
    {
        int testCase = Convert.ToInt32(Console.ReadLine());
        string[] strArray = new string[testCase];
        if (testCase > 50) return;
        for (int index = 0; index < testCase; index++)
        {
            string inputString = Console.ReadLine();
            strArray[index] = inputString;

        }

        for (int index = 0; index < strArray.Length; index++)
        {
            string[] str = strArray[index].Split(' ');
            for (int jIndex = 0; jIndex < str.Length; jIndex++)
            {
                var n = Convert.ToInt64(str[jIndex]);
                if (n < 2) break;
                jIndex++;
                var m = Convert.ToInt64(str[jIndex]);
                if (m > 1000000) break;
                jIndex++;
                var k = Convert.ToInt64(str[jIndex]);
                if (k < 1 || k > 100000) break;
                jIndex++;
                var l = Convert.ToInt64(str[jIndex]);
                if (l < 2 ) break;

                if (k >= m)
                    Console.WriteLine((n * m) + k + l);
                else
                    Console.WriteLine(n * m);

            }
        }
    }

}