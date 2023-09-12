using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate.Test1Sep
{
    internal class SumOfDigitInarray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string msg = Console.ReadLine();
            char[] chars = msg.ToCharArray();
            int sum = 0;
            for(int i=0 ; i<msg.Length; i++)
            {
                if (chars[i] >='0' && chars[i]<='9')
                {
                    int a = (int)(char.GetNumericValue(chars[i]));
                    sum =sum+ a;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
