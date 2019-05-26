
using System;
using System.IO;

public class Partition
{
    long count = 0;
    double appendValue =0;
    int r = 0;
    public void SetPartition()
    {
        var input1 = Console.ReadLine();
        var input2 = Console.ReadLine();
        var d= input2.Replace(" " ,"");
        double str = Convert.ToDouble(d);
        var case1 = input1.Split(' ');
        r = Convert.ToInt32(r);
        PartionString(str);

        


    }

    private int PartionString(double str)
    {
        
        var  value = str % 10;
        appendValue = value;
        var  replaceValue = (str - value)/ 10;
       
        if(count > 0){
        appendValue =   value *   Math.Pow(10,count) + appendValue;
        }
        count++;
if(appendValue > str){
return PartionString(appendValue);
}

         

      return  PartionString(replaceValue);

    }
}