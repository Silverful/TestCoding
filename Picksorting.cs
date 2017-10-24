using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> UnsortedList = new List<int> { 1, 5, 2, 9, 7,11, 3, 8,5,3 };
            PickSorter Sorter = new PickSorter();
            List<int> SortedList = Sorter.Sort(UnsortedList);
            foreach(int i in SortedList)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

    }
    public class PickSorter
    {
        public List<int> Sort(List<int> UnsortedList)
        {
            List<int> SortedList = new List<int>();
            int UnsLength = UnsortedList.Count;
            while (SortedList.Count != UnsLength)
            { 
                int max = UnsortedList[0];
                foreach (int j in UnsortedList)
                {
                    if (max <= j)
                        max = j;
                    
                }
                SortedList.Add(max);
                UnsortedList.Remove(max);
            }
            return SortedList;
        }
    }
}
