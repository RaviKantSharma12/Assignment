using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static Boolean isPalindrome(char[] charector)
        {
            if (charector.Length==0)
            { 
            return false;
            }
            int start = 0;
            int end = charector.Length-1;
            while(start < end) 
            {
            if (!(charector[start] == charector[end]))
                {
                    return false;
                }
            start++;
                end--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name= Console.ReadLine();
            name.ToLower();
            char[] name1= name.ToCharArray();
            Console.WriteLine(isPalindrome(name1));
        }
    }
}
