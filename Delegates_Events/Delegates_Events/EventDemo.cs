using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    public delegate void DelHandler();
    public class EventDemo
    {
        public event DelHandler Demo;
        public void India()
        {
            Console.WriteLine("INDIA");
        }
        public void Usa()
        {
            Console.WriteLine("USA");
        }
        public void Aus()
        {
            Console.WriteLine("AUSTRALIA");
        }
        public void Run()
        {
            Demo+=new DelHandler (India);
            Demo += new DelHandler(Usa);
            Demo += new DelHandler(Aus);
            Demo.Invoke();
        }
    }
}
