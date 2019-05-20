using System;


public class Pangram
{
    // check the all letter present in the string
    public string PangramString(string s)
    {
        bool isPangram = true;

        for (int i = 97; i <= 122; i++)
        {
            char c = (char)i;
            if (s.ToLower().IndexOf(c) == -1)
            {
                isPangram = false;
                break;
            }
           

        }
         return (isPangram ? "Pangram" : "Not Pangram");
    }
}