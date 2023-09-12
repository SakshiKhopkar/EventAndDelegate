using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate.Test1Sep
{
    internal class ReverseThestring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string msg2= Console.ReadLine();
            string rev = "";
            for (int i = msg2.Length - 1; i >= 0; i--)
            {
                rev = rev + msg2[i]; 
            }
            
            Console.WriteLine(rev);
        }
    }
}
