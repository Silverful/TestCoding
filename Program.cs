using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] SearchAr = new int[3] { 1, 3, 5 };
            int? res =  BinarySearchRec(SearchAr, 3);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int? BinarySearchRec(int[] Ar, int Search)
        {
            // Нижний порог, верхний порог - Средний элемент = искомому? - Если средний меньше искомого, то
            // средний = нижний, верхний не трогать, пробегаем массив заново - если средний больше искомого, то нижний не трогать, верхний = средний
            int low = 0;
            int high = Ar.Length - 1;

           return  BinarySearchRec(Ar, Search, low, high);
            
        }
        public static int? BinarySearchRec(int[] Ar, int Search, int lowp, int highp)
        {
            int mid = (highp + lowp) / 2;
            if (lowp <= highp)
            {
                if (Ar[mid] == Search)
                {
                    
                    return mid+1;
                }
                else if (Ar[mid] < Search)
                   return BinarySearchRec(Ar, Search, mid+1, highp);
                
                else if (Ar[mid] > Search)
                    return BinarySearchRec(Ar, Search, lowp, mid-1);
                
            }
            return null;
        }
        public static void BinarySearch(int[] Ar, int Search)
        {
            int low = 0;
            int high = Ar.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = Ar[mid];
                if (guess == Search)
                {
                    Console.WriteLine("Такой элемент есть, он находится в {0} ячейке", mid+1);
                    return;
                }
                    if (guess > Search)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            Console.WriteLine("Нет такого значения!");
        }
    }

}
