using System;

namespace Interp_Search //O(log N)
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array.Sort(mas);
            Console.WriteLine(interpolationSearch(mas,6));
        }
        
        static int interpolationSearch(int[] arr, int num)
        {
            Array.Sort(arr);
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right & num >= arr[left] & num <= arr[right])   
            {
                int index = left + (int)(((float)(right - left) / (arr[right] - arr[left])) * (num - arr[left]));
                if (arr[index] == num){
                    return index;   
                }
                else if (arr[index] < num){
                    left = index + 1;
                }
                else
                {
                    right = index - 1;
                }
            }

            return -1;
        }

    }
}
