using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Program
    {
        struct MyStruct
        {
            

            //Struct method
            public static void CountElementFrequency(int[] arr)
            {
                Array.Sort(arr);
                bool[] visited = new bool[arr.Length];

                for (int i = 0; i < arr.Length; i++)
                {

                    if (visited[i] == true)
                        continue;

                    int count = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            visited[j] = true;
                            count++;
                        }
                    }
                    Console.WriteLine(arr[i] + " " + count);
                }

            }

            //Write a program in C# Sharp to count the frequency of each element of an array with the usage of struct/class
            static void Main(string[] args)
            {
                int[] arr = { 1, 5, 2, 3, 4, 1, 2, 2, 4, 5 };


                MyStruct.CountElementFrequency(arr);

                
                Console.ReadKey();



            }

        }
    }
}