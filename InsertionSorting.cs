using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Ar = new int[] { 3, 7, 4, 4, 6, 5, 8 };
            Console.WriteLine("Before sorting: ");
            foreach (int i in Ar)
                Console.Write(i + " ");
            InsertionSorter.InsertionSort(Ar);
            Console.WriteLine("After sorting: ");
            foreach (int i in Ar)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }
    public static class InsertionSorter
    {
        public static void InsertionSort(int[] Ar)
        {
            int curPos = 1;

            do
            {
                if (Ar[curPos] < Ar[curPos - 1])
                {
                    int InsertIndex = FindIndex(Ar, curPos);
                    Insertion(Ar, InsertIndex, curPos);
                }
                curPos++;
            } while (curPos < Ar.Length);
        }
        private static int FindIndex(int[] Ar, int curPos)
        {
            for (int i = 0; i < curPos; i++)
                if (Ar[i] > Ar[curPos])
                    return i;
            throw new InvalidOperationException("=(");
        }
        private static void Insertion(int[] Ar, int IndexToInsert, int curPos)
        {
            int temp = Ar[IndexToInsert];
            Ar[IndexToInsert] = Ar[curPos];
            for (int index = curPos; index > IndexToInsert;index--)
            {
                Ar[index] = Ar[index - 1];
            }
            Ar[IndexToInsert + 1] = temp;
        }
    }
}
