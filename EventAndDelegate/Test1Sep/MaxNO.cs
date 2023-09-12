using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate.Test1Sep
{
    internal class MaxNO
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 8, 9, 1 };
            int max = array[0];
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] > max)
                {
                   max= array[i];
                }
            }
            Console.WriteLine("max from array is"+max);
        }
    }
}
