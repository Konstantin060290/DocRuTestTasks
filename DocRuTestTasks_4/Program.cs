using System;

namespace DocRuTestTasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter a natural number:");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("Result:");
                Console.WriteLine("{0}", MyFunc(input));
            }
        }
        public static int MyFunc(int input)
        {
            int sum = 0;
            bool flag = true;
            try
            {
                if (input < 0)
                {
                    throw new Exception("Input number isn't not a natural number");
                }
                while (flag)
                {   
                    sum = 0;
                    for (int i = 0; i < input.ToString().Length; i++)
                    {
                        sum += int.Parse(input.ToString()[i].ToString());
                    }
                    input = 0;
                    if (sum > 9)
                        {
                            flag = true;
                        }
                        else
                        { 
                            flag = false;
                        }
                    for (int i = 0; i < sum.ToString().Length; i++)
                    {
                        input += int.Parse(sum.ToString()[i].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sum;
        }
    }
}
