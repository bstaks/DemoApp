using System;
using System.Linq;

namespace Algo
{
    public class SortingAlgo
    {
        public void GetString(int number)
        {
            string[] vowel = { "A", "E", "I", "O", "U" };
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                string tree = Console.ReadLine();
                for (int j = 0; j < tree.Length; j++)
                {
                    if (vowel.Contains(tree[j].ToString().ToUpper()))
                    {
                        count++;

                    }

                }
                Console.WriteLine($"{count}");

                count = 0;
            }
        }


        public void SortArray()
        {
            int[] number = { 3, 6, 3, 8, 4, 9, 0 };
            for (int i = 0; i < number.Length; ++i)
            {
                for (int j = i + 1; j < number.Length; ++j)
                {
                    if (number[j] < number[i])
                    {
                        int c = number[i];
                        number[i] = number[j];
                        number[j] = c;
                    }
                }

               
            }

             for (int i = 0; i < number.Length; i++)
                {
                    Console.WriteLine($"{number[i]}");
                }
        }

        public void SortString(){
            string[] str={"ABhishek","Kumar","I","am"};
            for(int i = 0; i < str.Length; ++i){
                for(int j = i+1 ; j< str.Length; ++j){
                    if(str[i].Length > str[j].Length){
                     string  str1 = str[i].ToString();
                     str[i] = str[j];
                     str[j] = str1;
                    }
                }
            }

            for(int i = 0 ; i < str.Length; i++){
                Console.WriteLine($"{str[i]}");
            }
        }
    }
}