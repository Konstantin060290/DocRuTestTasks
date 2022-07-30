using System;

namespace DocRuTestTasks_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter a row of triangle:");
                string input = Console.ReadLine();
                Console.WriteLine("Sum of triabgle row:{0}", Sum(int.Parse(input)));
            }
        }
            public static int Sum(int row)
        {
            int sum = 0;
            int size = 0;
            //Find quantity of digits in array
            for (int i = row; i > 0; i--)
            {
                size += i;
            }
            int [] arr = new int [size];
            int value = 1;
            //Fill array by odd digits
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
                value += 2;
            }
            //Calculate sum
            for (int  i = size-1; i > size-1-row; i--)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
