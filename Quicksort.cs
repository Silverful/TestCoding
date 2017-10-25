using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Uns = new int[5] { 2, 9, 1, 6, 90 };
            Quicksort(Uns);
            foreach (int i in Uns)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            
        }
        static void Quicksort(int[] UnsortedAr)
        {
            Quicksort(UnsortedAr, 0, UnsortedAr.Length - 1);
        }
        static void Quicksort(int[] UnsortedAr, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = UnsortedAr[(left + right) / 2];

            while (i<=j)
            {
                while (UnsortedAr[i] < pivot) i++;
                while (UnsortedAr[j] > pivot) j--;

                if (i<=j)
                {
                    int temp = UnsortedAr[i];
                    UnsortedAr[i] = UnsortedAr[j];
                    UnsortedAr[j] = temp;

                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                Quicksort(UnsortedAr, left, j);
            }
            if (i < right)
            {
                Quicksort(UnsortedAr, i, right);
            }
        }
    }
}
