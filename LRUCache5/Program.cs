using System;
using System.Collections.Generic;
using System.Linq;

namespace LRUCache5
{
    class Program
    {
        public class LRUCache
        {
            class ValueCount
            {
                public int val { get; set; }
                public DateTime time { get; set; }
            }
            public int Size = 0;
            Dictionary<int, ValueCount> dict = new Dictionary<int, ValueCount>();
            public LRUCache(int size)
            {
                this.Size = size;
            }
            public int Get(int x)
            {
                if (!dict.ContainsKey(x))
                    return -1;
                dict[x].time = DateTime.Now;
                Console.WriteLine("Get The Value of :  " +x+ " is    :" + dict[x].val);
                return dict[x].val;
            }
            public void Set(int x, int y)
            {
                if (dict.ContainsKey(x))
                    return;
                if (dict.Count >= Size)
                {
                    List<KeyValuePair<int, ValueCount>> l1 = dict.ToList();
                    l1.Sort((p1, p2) => p1.Value.time.CompareTo(p2.Value.time));
                    int leastUsed = l1[0].Key;
                    dict.Remove(leastUsed);
                }
                if (!dict.ContainsKey(x) && dict.Count < Size)
                {
                    dict.Add(x, new ValueCount { val = y, time = DateTime.Now });
                }
            }
            public void Print()
            {
                List<KeyValuePair<int, ValueCount>> dicList = dict.ToList();
                foreach (KeyValuePair<int, ValueCount> pair in dicList)
                {
                    Console.WriteLine("The value of :  " + pair.Key + "is Equal to:  " + pair.Value.val);
                }
            }
        }
        static void Main(string[] args)
        {
            LRUCache lr = new LRUCache(5);
            lr.Set(1, 101);
            lr.Set(2, 202);
            lr.Set(3, 303);
            lr.Set(4, 404);
            lr.Set(5, 505);
            
            //here i am going to get 1,3,4,5
            //so least recently used value is 2
            //if i want to set 6 th vlaue in my cache 2 value is going to be removed
            //because my cache size is 5
            lr.Get(3);
            lr.Get(4);
            lr.Get(5);
            lr.Get(1);
            Console.WriteLine();
            //before setting the new value i am printing my cache values
            Console.WriteLine("The list of my dictionary values are  :");
            lr.Print();
            Console.WriteLine();
            //now i am going to add 6 th value my cache was 5 so recently use value is 2
            //i want to remove 2 and add 6 after setting i am going to print all dictionary values
            lr.Set(6, 606);
            lr.Print();
            Console.Read();
        }
    }
}
