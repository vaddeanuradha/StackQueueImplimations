using System;
using System.Collections;

namespace ImpQueueWith2Stacks2
{
    class Program
    {
        public class Queue
        {
            public Stack st1 = new Stack();
            public Stack st2 = new Stack();
            int size = 0;
            public void enQueue(int x)
            {
                st1.Push(x);
                size++;
            }
            public int deQueue()
            {
                if(st1.Count==0&&st2.Count==0)
                {
                    Console.WriteLine("Queue is Empty:");
                    
                }
                if(st2.Count==0)
                {
                    while(st1.Count>0)
                    {
                        st2.Push(st1.Pop());
                    }
                }
                int x = (int)st2.Peek();
                st2.Pop();
                return x;
            }
            public int peek()
            {
                if (st1.Count==0)
                {
                    Console.WriteLine("The Queue is Empty  :");
                    return -1;
                }
                else
                {
                    Console.WriteLine("The Peek element of this queue is  :" + (int)st1.Peek());
                    return (int)st1.Peek();
                }
                
            }
            public int count()
            {
                if (st1.Count==0)
                {
                    Console.WriteLine("The Queue is Empty  :");
                    return -1;
                }
                else
                {
                    Console.WriteLine("The number of the elements in Queue is   :" + size);
                    return size;
                }
            }
        }
       
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.enQueue(1);
            q.enQueue(2);
            q.enQueue(4);
            q.peek();
            q.count();


            Console.Write(q.deQueue() + " ");
            Console.Write(q.deQueue() + " ");
            Console.Write(q.deQueue());
            Console.Read();
        }
    }
}
