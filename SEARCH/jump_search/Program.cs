using System;

namespace jump_search//O(sqrt(N))
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Jump_Search(arr,5));
        }

        static int Jump_Search(int[] arr, int num)
        {
            Array.Sort(arr);
            int n = arr.Length;
            int step = Convert.ToInt32(Math.Sqrt((double)n));
            int prev = 0;
            while(arr[Math.Min(step,n)-1] < num)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            while (arr[prev] < num)
            {
                prev++;
                // Если мы достигли следующего блока или конца
                // массив, элемент отсутствует.
                if (prev == Math.Min(step, n))
                    return -1;
            }

            if (arr[prev] == num)
                return prev;

            return -1;
        }
    }
}
