using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocRuTestTasks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();
                if (int.Parse(input) <= 0)
                {
                    Console.WriteLine("Number must be positive and more than zero.");
                }
                else
                {
                    Console.WriteLine("Result:{0}", ModifyNumber(int.Parse(input)));
                }

            }
        }
        public static int ModifyNumber(int number)
        {
            StringBuilder strnumber = new StringBuilder(number.ToString());
             
                for (int i = 0; i < number.ToString().Length; i++)
                {
                    for (int j = 0; j < number.ToString().Length - 1; j++)
                    {
                        if (int.Parse(strnumber[j].ToString()) < int.Parse(strnumber[j + 1].ToString()))
                        {
                            string num = strnumber[j].ToString();
                            strnumber[j] = strnumber[j + 1];
                            strnumber[j + 1] = Convert.ToChar(num);
                        }
                    }
                }   
            int modnumber = int.Parse(strnumber.ToString());
            return modnumber;
        }
    }
}
