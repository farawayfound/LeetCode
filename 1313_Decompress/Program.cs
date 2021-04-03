using System;

//another challenge: how to tell if an integer is a pallindrome

namespace _1313_Decompress
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 1, 2, 3, 4, 2};
            int[] resultArray = Decompress(testArray);
            foreach (int x in resultArray)
            {
                Console.Write(x + " ");
            }
        }
        public static int[] Decompress(int[] nums)
        {
            //initializing result array to the correct length
            int l = 0;
            for (int i = 0; i < nums.Length; i+= 2)
            {
                l += nums[i];
            }
            int[] result = new int[l];

            //
            int temp = 0;
            for (int i = 0; i < nums.Length; i+= 2)
            {
                int j = i + 1;
                int freq = nums[i];
                int value = nums[j];
                for (int k = temp; k < temp + freq; k++)
                {
                    result[k] = value; 
                }
                temp += freq;
            }

            return result;
        }
    }
}
