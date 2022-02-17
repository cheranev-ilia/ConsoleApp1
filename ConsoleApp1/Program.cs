using System;

namespace lab_1
{
    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int time = 0, MaxTime, ind;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = customers[i];
            ind = n;

            while (true)
            {
                time++;
                for (int j = 0; j < n; j++)
                {
                    arr[j]--;

                    if (arr[j] == 0 && ind != customers.Length)
                    {
                        arr[j] = customers[ind];
                        ind++;
                    }
                }
                if (ind == customers.Length)
                    break;
            }

            MaxTime = arr[0];
            for (int i = 1; i < n; i++)
                if (MaxTime < arr[i])
                    MaxTime = arr[i];
            time += MaxTime;
            return time;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            long time;
            int[] a = new int[] { 5, 3, 4 };
            int[] b = new int[] { 10, 2, 3, 3 };
            int[] c = new int[] { 2, 3, 10 };

            time = HW1.QueueTime(a, 1);
            Console.WriteLine($"Необходимое время 1 : {time}");
            time = HW1.QueueTime(b, 2);
            Console.WriteLine($"Необходимое время 2 : {time}");
            time = HW1.QueueTime(c, 2);
            Console.WriteLine($"Необходимое время 3 : {time}");
        }
    }
}