using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticReadonly
{
    internal class Program
    {
         static string college="Invia";
         int id;

        Program(int pid) 
        {
            id = pid;
        }
     
        static void Main(string[] args)
        {
            Program obj = new Program(100);
            Program obj2 = new Program(110);
            Program obj3 = new Program(111);
            Console.WriteLine("Our id is "+obj.id+" college "+college);
            Console.WriteLine("Our id is " + obj2.id + " college " + college);
            Console.WriteLine("Our id is " + obj3.id + " college " + college);
        }
    }
}
