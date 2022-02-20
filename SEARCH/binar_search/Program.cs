using System;

namespace binar_search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================================================");
            int[] massive = { 1, 2, 5, 3, 23, 523523, 6, 724, 724, 72, 78, 6, 4, 7, 7, 7, 5, 22424, 547, 8685, 958, 435 };
            Console.WriteLine(bin_search(massive,547));
        }
        public static int bin_search(int[] arr, int num)//O(log N)
        {
            Array.Sort(arr);
            
            int leftIndex = 0;
            int rightIndex = arr.Length - 1;
            while (leftIndex <= rightIndex)
            {
                int midIndex = (leftIndex + rightIndex) / 2;
                if (arr[midIndex] == num)
                {
                    return midIndex;
                }
                else if (arr[midIndex] > num) 
                {
                    rightIndex = midIndex - 1;
                }
                else
                {
                    leftIndex = midIndex + 1;
                }
                
            }
            return -1;
        }
    }
}


