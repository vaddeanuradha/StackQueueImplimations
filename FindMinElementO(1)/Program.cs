using System;
using System.Collections;

namespace FindMinElementO_1_
{
    class Program
    {
        public class MyStack
        {
            public Stack st;
            public int min;
            public MyStack()
            {
                st = new Stack();
            }
            public void Push(int x)
            {
                if (st.Count==0)
                {
                    st.Push(x);
                    min = x;
                    Console.WriteLine("Number Inserted: " + x);
                    return;
                }
                if (x < min)
                {
                    st.Push(2 * x - min);
                    min = x;
                }
                else
                    st.Push(x);

                Console.WriteLine("Number Inserted: " + x);
            }
            
            public void Pop()
            {
                if (st.Count==0)
                {
                    Console.WriteLine("The Stack is Empty: ");
                    return;
                }
                Console.Write("Top Most Element Removed:  ");
                int t = (int)st.Pop();
                if (t < min)
                {
                    Console.WriteLine(min);
                    min = 2 * min - t;
                }
                else
                    Console.WriteLine(t);
            }

            public void Peek()
            {
                if (st.Count==0)
                {
                    Console.WriteLine("The Stack is Empty:  ");
                    return;
                }
                int t = (int)st.Peek();
                Console.Write("The TopMost Element is : ");
                if (t < min)
                    Console.WriteLine(min);
                else
                    Console.WriteLine(t);
            }

            public void GetMin()
            {
                if (st.Count == 0)
                    Console.WriteLine("The Stack is Empty:  ");
                else
                    Console.WriteLine("The Minimum Element in the Stack is :" + min);
              
                
            }
        }
        static void Main(string[] args)
        {
            MyStack st = new MyStack();
            st.Push(4);
            st.Push(3);
            st.GetMin();
            st.Push(2);
            st.Push(6);
            st.Push(5);
            st.GetMin();
            st.Pop();
            st.Peek();
            st.GetMin();
            Console.Read();
           
        }
    }
}
