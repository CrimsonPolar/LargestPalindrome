using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultCount = 0;
            int largestProduct = 0;
            string printLargestProduct = "";
            for(int i = 111; i <= 999; i++)
            {
                for (int j = 111; j <= 999; j++)
                {
                    int product = i * j;
                    if (CheckIfPalindrome(product))
                    {
                        resultCount++;
                        //Console.WriteLine(i + "x" + j + "=" + product);
                        if (product > largestProduct)
                        {
                            largestProduct = product;
                            printLargestProduct = i + "x" + j + "=" + largestProduct;
                        }
                    }
                }
            }
            Console.WriteLine("Done! " + resultCount + " results" + "\n" + "largest palindrome's equation was " + printLargestProduct);
            PressAnyToExit();
        }
        
        static bool CheckIfPalindrome(int num)
        {
            int[] check1 = IntToIntArray(num);
            if (check1.SequenceEqual(check1.Reverse()))
                return true;
            else
                return false;
        }
        public static int[] IntToIntArray(int num)
        {
            if (num == 0)
                return new int[1] { 0 };

            List<int> digits = new List<int>();

            for (; num != 0; num /= 10)
                digits.Add(num % 10);

            int[] array = digits.ToArray();
            System.Array.Reverse(array);

            return array;
        }
        static void PressAnyToExit()
        {
            Console.WriteLine("\n" + "Press Any Key to Exit...");
            Console.ReadKey();
        }
    }
}
