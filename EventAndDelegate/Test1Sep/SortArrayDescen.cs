using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate.Test1Sep
{
    internal class SortArrayDescen
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 9, 8, 2, 3 };//array[0]=3,array[1]=4
            for(int i=0; i<array.Length; i++)
            {
               for(int j=i+1;j<array.Length; j++)
               {
                    if (array[j] > array[i])
                    {
                       int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                   
               }
            }
            Console.WriteLine("desending order");
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
