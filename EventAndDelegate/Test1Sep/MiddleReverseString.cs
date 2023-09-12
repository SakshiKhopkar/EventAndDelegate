using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate.Test1Sep
{
    internal class MiddleReverseString
    {
        static void Main(string[] args)
        {
            string str = "hello to all";
            string[] str2 = str.Split(' ');
            string rev = "";
            for(int i= str2.Length - 2;i>=1 ; i--)
            {
                Console.WriteLine(str2[i]);
            }
            Console.WriteLine(rev);
        }
    }
}
