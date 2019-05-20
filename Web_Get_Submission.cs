

using System;
using System.Web;
using System.Net.Http;
public class Web_Get
{
    public void GetSubmission()
    {
        HttpClient client = new HttpClient();
        for (int index = 24747149; index < 24747150; index++)
        {
            
            var get = client.GetStringAsync($"https://www.hackerearth.com/challenges/competitive/march-circuits-19/algorithm/does-it-divide-3c60b8fb/submission/{index}/");
            if (get != null)
            {
                Console.WriteLine($"{get.Result}");
                 Console.WriteLine($"{get}");
            }
        }

    }
}