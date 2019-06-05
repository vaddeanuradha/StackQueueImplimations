using System;
using System.Collections;

namespace PrintNGE1
{
    class Program
    {
        public static void PrintNGE(int[] arr,int n)
        {
            Stack st = new Stack();
            int[] arr1 = new int[n];
            int max = 0;
            for (int i =n-1;i>=0;i--)
            {

                if (st.Count > 0 && (int)st.Peek() < arr[i])
                {
                    st.Pop();
                }

                if (st.Count == 0)
                {
                    arr1[i] = -1;
                    max = arr[i];
                }
                else if (max<arr[i] && (int)st.Peek() < arr[i])
                    arr1[i] = -1;
                else if ((int)st.Peek() > arr[i])
                    arr1[i] = (int)st.Peek();
                else if(max>arr[i])
                    arr1[i] = max;

                    st.Push(arr[i]);
                if (max < (int)st.Peek())
                    max = (int)st.Peek();

            }
            for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i] + "--->" + arr1[i]);
            Console.Read();
        }

        
        static void Main(string[] args)
        {
            int[] arr = {14,12,9,10,13,8 ,9};
            int size = arr.Length;
            Console.WriteLine("The array elements are: ");
            for (int i = 0; i < size; i++)
                Console.Write("  " + arr[i]);

            Console.WriteLine();
            Console.WriteLine("The next greatest element of the each element is: ");
            PrintNGE(arr, size);

        }
    }
}
