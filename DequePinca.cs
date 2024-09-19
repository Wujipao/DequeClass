using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class DequePinca<T>
    {
        private T[] deque;
        private int front, rear, count, size;

        public DequePinca(int size)
        {
            this.deque = new T[size];
            this.front = -1;
            this.rear = -1;
            this.count = 0;
            this.size = size;
        }
        public bool isEmpty()
        {
            return count == 0;
        }
        public bool isFull()
        {
            return count == size;
        }
        public void AddRear(T value)
        {
            if (isFull())
            {
                throw new Exception("Deque is full.");
            }
            if (isEmpty())
            {
                front = 0;
                rear = 0;
            }
            else
            {
                rear = (rear + 1) % size;
            }
            deque[rear] = value;
            count++;
        }
        public void AddFront(T value)
        {
            if (isFull())
            {
                throw new Exception("Queue is full.");
            }
            if (isEmpty())
            {
                front = 0;
                rear = 0;
            }
            else
            {
                front = (front - 1 + size) % size;
            }
            deque[front] = value;
            count++;
        }
        public void RemoveFront()
        {
            if (isEmpty())
            {
                throw new Exception("Deque is empty.");
            }
            T removed = deque[front];
            front = (front + 1) % size;
            count--;
            if (isEmpty())
            {
                front = -1;
                rear = -1;
            }
        }
        public void RemoveBack()
        {
            if (isEmpty())
            {
                throw new Exception("Deque is empty.");
            }
            T removed = deque[rear];
            rear = (rear - 1 + size) % size;
            count--;
            if (isEmpty())
            {
                front = -1;
                rear = -1;
            }
        }
        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deque is empty.");
                return;
            }

            int i = front;
            int itemsDisplayed = 0;

            Console.Write("Deque elements: ");
            while (itemsDisplayed < count)
            {
                Console.Write(deque[i] + " ");
                i = (i + 1) % size;
                itemsDisplayed++;
            }
            Console.WriteLine();
        }

    }
}
