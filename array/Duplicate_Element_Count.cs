using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment.array
{
   /*internal class Duplicate_Element_Count
    {
        //WAP to find and count total number of duplicate elements in an array.
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine( "Enter Elements in Array");
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < array.Length; i++)
                {
                    bool isvisited = true;
                    int count = 1;
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (array[k] == array[i])
                        {
                            isvisited = false;
                            break;
                        }
                    }
                    if (isvisited)
                    {
                        for (int j = i + 1; j < array.Length; j++)
                        {
                            if (array[i] == array[j])
                            {
                                isvisited = false;
                                count++;
                            }
                        }
                        if (count > 1)
                        {
                            Console.WriteLine($"Duplicate Elements Are{array[i]} and Count is{count}");
                        }
                    }
                }
            }
        }
    }*/
}
