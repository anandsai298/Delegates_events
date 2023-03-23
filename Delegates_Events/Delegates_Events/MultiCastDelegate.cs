using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    public delegate int MultiOperation(int y, int z);
    public class MultiCastDelegate
    {
        public int Add(int a, int b)
        {
            Console.WriteLine(a + "+" + b+"="+(a+b));
            return a + b;
        }
        public int Mutliplication(int a, int b)
        {
            Console.WriteLine(a + "*" + b + "=" + (a * b));
            return a * b;
        }
        public void Run()
        {
            MultiOperation multiOperation = Add;
            multiOperation += Mutliplication;
            multiOperation(3, 5);
            multiOperation(9, 8);
        }
    }
}
