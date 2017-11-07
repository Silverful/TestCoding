using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Ar = new int[] {10,3,1 };
            Console.WriteLine("Unsorted Array:");
            foreach (int i in Ar)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");

            BubleSorter.BubleSorting(Ar);
            Console.WriteLine("Sorted Array: ");
            foreach (int i in Ar)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
    static class BubleSorter
    {
        public static void BubleSorting(int[] Ar)
        {
            bool Sort;
            do
            {
                Sort = false;
                for (int i = 1; i < Ar.Length; i++)
                {
                    if (Ar[i - 1] >= Ar[i])
                    {
                        Swap(Ar, i - 1, i);
                        Sort = true;
                    }
                }
 

            } while (Sort == true);
        }
        private static void Swap(int[] Ar, int left, int right)
        {
            if (left != right)
            {
                int temp = Ar[left];
                Ar[left] = Ar[right];
                Ar[right] = temp;
            }
        }
    }

}
