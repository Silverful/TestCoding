using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PickSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Ar = new int[] { 11,1, 5,8, 9, 2, 8, 7 };
            Console.WriteLine("Before sorting: ");
            foreach (int i in Ar)
                Console.Write(i + " ");
            Console.WriteLine("\n After Sorting:");
            PickSort.PickSorting(Ar);
            foreach (int i in Ar)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }
    static class PickSort
    {
        public static void PickSorting(int[]Ar)
        {
            for (int i = 0; i < Ar.Length-1; i++)
            {
                int min = Ar[i];
                int minIndex = i;
                for (int j = i; j < Ar.Length; j++)
                {
                    if (Ar[j] < min)
                    {
                        min = Ar[j];
                        minIndex = j;
                    }
                }
                int temp = Ar[i];
                Ar[i] = min;
                Ar[minIndex] = temp;
            }
        }
    }
}
