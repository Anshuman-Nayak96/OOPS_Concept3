using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept3
{
    class Parent
    {
        internal string name="Parent";
    }
    class child:Parent
    {
        string name="Child";
        internal void display()
        {
            Console.WriteLine("The parent class name is "+base.name+"  "+ "The child class name is "+name);
            Console.Read();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var? i = null;
            //var i, j;
            //var i = 10, j;
            child obj = new child();
            obj.display();
        }
    }
}
