using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class DequeTestt
    {
        public static void Main(string[] args)
        {
            DequePinca<int> dq = new DequePinca<int>(5);

            dq.AddRear(1);
            dq.AddRear(2);
            dq.AddRear(3);
            dq.AddRear(4);
            dq.AddFront(5);

            dq.Display();

            dq.RemoveBack();
            dq.RemoveFront();

            dq.Display();


        }
    }
}
