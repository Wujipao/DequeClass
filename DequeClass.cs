using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class DequeClass<T>
    {
        private LinkedListClass<T> list; 

        public DequeClass()
        {
            this.list = new LinkedListClass<T>();
        }
        public void AddFront(T front)
        {
            list.AddFront(front);
        }
        public void AddBack(T back)
        {
            list.AddBack(back);
        }
        public T RemoveFront()
        {
            if (list.Count == 0)
            {
                throw new Exception("Deque is empty.");
            }
            T value = list.First;
            list.RemoveFront();
            return value;
        }
        public T RemoveBack()
        {
            if (list.Count == 0)
            {
                throw new Exception("Deque is empty.");
            }
            T value = list.Last;
            list.RemoveBack();
            return value;
        }
        public int Count
        {
            get { return list.Count; }
        }
    }
}
