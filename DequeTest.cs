using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class DequeTest
    {
        static void Main(string[] args)
        {
            DequeClass<string> dq = new DequeClass<string>();

            dq.AddFront("a");
            dq.AddFront("b");
            dq.AddFront("c");
            dq.AddFront("d");

            while (dq.Count > 0)
            {
                Console.WriteLine("Items: " + dq.RemoveBack());
            }
        }
    }
}
