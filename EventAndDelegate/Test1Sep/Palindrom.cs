using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate.Test1Sep
{
    internal class Palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int no= Convert.ToInt32(Console.ReadLine());
            int temp = no;
            int rev = 0;
            while (no > 0)
            {
                int rem = no % 10;
                rev= rev* 10+rem;
                no=no/10;
            }
            if (rev == temp)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}
