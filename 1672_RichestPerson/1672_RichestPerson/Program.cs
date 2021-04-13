using System;

namespace _1672_RichestPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int MaxWealth(int[][] accounts)
        {
            int max = 0;
            for (int j = 0; j < accounts.Length; j++)
            {
                int total = 0;
                for (int k = 0; k < accounts[j].Length; k++)
                {
                    total = total + accounts[j][k];
                    if (max < total)
                    {
                        max = total;
                    }
                }
            }
            return max;
        }
    }
}
