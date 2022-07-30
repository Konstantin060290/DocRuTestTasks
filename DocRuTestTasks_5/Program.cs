using System;
using System.Collections.Generic;

namespace DocRuTestTasks_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter a quantity of coints:");
                string inp = Console.ReadLine();
                if (inp.Contains("."))
                    { inp = inp.Replace(".", ","); }
                float input = float.Parse(inp);
                Console.WriteLine("Result:");
                foreach (var coins in CountCoins(input))
                    {
                    Console.Write(coins.Key + ":");
                    Console.Write(coins.Value);
                    Console.WriteLine();
                }
            }
        }
        public static Dictionary<string, int> CountCoins(float cents)
        {
            int floorcents = (int)Math.Floor(cents);
            var result = new Dictionary<string, int>();
            if (cents == 0 || cents < 0)
            {
                result.Add("Nickles", 0);
                result.Add("Pennies", 0);
                result.Add("Dimes", 0);
                result.Add("Quarters", 0);
            }
            else
            {
                int quarters = floorcents / 25;
                int rest = floorcents - quarters * 25;
                int dimes = rest / 10;
                rest = rest - dimes * 10;
                int nickels = rest / 5;
                rest = rest - nickels * 5;
                int pennies = rest;
                result.Add("Nickles", nickels);
                result.Add("Pennies", pennies);
                result.Add("Dimes", dimes);
                result.Add("Quarters", quarters);
            }
            return result;

        }
    }
}
