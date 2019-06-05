using System;
using System.Collections;

namespace ImpStackWith2Queues3
{
    class Program
    {
        public class Stack
        {
            // Two inbuilt queues  
            public Queue q1 = new Queue();
            public Queue q2 = new Queue();

            // To maintain current number of  
            // elements  
            public int curr_size;

            public Stack()
            {
                curr_size = 0;
            }

            public void push(int x)
            {
                curr_size++;

                // Push x first in empty q2  
                q2.Enqueue(x);

                // Push all the remaining  
                // elements in q1 to q2.  
                while (q1.Count > 0)
                {
                    q2.Enqueue(q1.Peek());
                    q1.Dequeue();
                }

                // swap the names of two queues  
                Queue q = q1;
                q1 = q2;
                q2 = q;
            }

            public int pop()
            {

                // if no elements are there in q1  
                if (q1.Count == 0)
                {
                    Console.WriteLine("The Stack is Empty:");
                    return -1;
                }


                int x = (int)q1.Peek();
                q1.Dequeue();
                curr_size--;
                Console.WriteLine("The Element is Poped from Stack  :" + x);
                return x;
            }

            public int top()
            {
                if (q1.Count == 0)
                {
                    Console.WriteLine("The Stack is Empty:");
                    return -1;
                }
                else
                {
                    Console.WriteLine("The top element of the stack is  :" + (int)q1.Peek());
                    return (int)q1.Peek();
                }
            }

            public int size()

            {
                if (q1.Count == 0)
                {
                    Console.WriteLine("The Stack is Empty:");
                    return -1;
                }
                else
                {
                    Console.WriteLine("The Size of the Stack is  :" + curr_size);
                    return curr_size;
                }
            }
        }
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.push(1);
            s.push(2);
            s.push(4);

            s.top();
            s.pop();
            s.top();
            s.pop();
            s.top();
            s.size();
            Console.Read();
        }
    }
}
