using System;
using System.Collections.Generic;

namespace RemoveDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!"); 
            int[] a = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            HashSet<int> h = new HashSet<int>();
            for(int i=0; i< a.Length; i++)
            {
                if(!h.Contains(a[i]))
                {
                    h.Add(a[i]);
                }
            }
            Array.Clear(a, 0, a.Length);
            int j = 0;
            foreach(int i in h)
            {
                if (j < h.Count)
                {
                    a[j++] = i;
                    //Console.WriteLine(a[j++]);
                }
            }
            Console.WriteLine(h.Count);
            Console.ReadLine();
        }
    }
}
