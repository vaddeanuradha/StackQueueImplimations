using System;
using System.Collections;
using System.Collections.Generic;
namespace FindNonRepeatingChar6
{
    class Program
    {
        public static Dictionary<char, int> d = new Dictionary<char, int>();
        public static Queue q = new Queue();

        public static void NonRepeatingChar(char ch)
        {
            //Dictionary<char, int> d = new Dictionary<char, int>();
            //Queue q = new Queue();
            if (!d.ContainsKey(ch))
            {
                d.Add(ch, 1);
                q.Enqueue(ch);
            }
            else
                d[ch]++;
            if (d[(char)q.Peek()] > 1)
                q.Dequeue();
            if (q.Count > 0)
            {
                Console.Write("The first Non Repeating Charecter is :  ");

                if (d[(char)q.Peek()] == 1)
                    Console.WriteLine((char)q.Peek());
                else
                    Console.WriteLine(-1);
            }
        }
        public static void Main(string[] args)
        {
            string str = "geegksforgeegksfor";
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                NonRepeatingChar(str[i]);
            }
            Console.Read();

        }
    }
}
