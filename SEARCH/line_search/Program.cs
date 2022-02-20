using System;

namespace line_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 33, 4, 27, 9, 14, 8, 0 };
            // O(N)
            Console.WriteLine("Index arr " + l_s(arr,4));
        }

        public static int l_s(int[] arr, int num)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num){
                    return i;
                    
                }

            }
            return -1;
        }
    }
}
