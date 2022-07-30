using System;

namespace DocRuTestTasks_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Return5().ToString());
            Console.ReadLine();
        }

       public static int Return5()
        {
            string[] arr = { "Just", "return", "quantity", "of", "elements" };
            return arr.Length;
        }
    }
}
