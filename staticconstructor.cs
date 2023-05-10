using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconstructor
{
    internal class home
    {
       static string officeaddress;
        static readonly int lwp;
        static home() //this is static constructor...it is paramterless
        {
            officeaddress = "lajpatnagr";
            lwp = 2;
            

            Console.WriteLine("Static constructor");
        }
        public static void Main()
        {
            Console.WriteLine(officeaddress);
            Console.WriteLine(lwp);
            //lwp = 4; //can not change
            officeaddress = "noida 58";
            Console.WriteLine(lwp + " " + officeaddress);
        }
    
   
    }
}
