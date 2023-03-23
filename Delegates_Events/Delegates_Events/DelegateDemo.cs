using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    public delegate int Operation(int x,int y);
    public class DelegateDemo
    {
        public int Add(int a,int b) 
        {
            return a + b;
        }
        public void Run()
        {
            Operation operation = new Operation(Add);
            Console.WriteLine(operation(1, 2));
        }
    }
}
