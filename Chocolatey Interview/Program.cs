using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolatey_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleToMulti(new int[] { 1, 2, 3, 4, 5, 6 }, 2, 3);
            Console.ReadKey();
        }

        /// <summary>
        /// Determines if a given string is a palindrome (if the string is the same forwards and backwards).
        /// </summary>
        /// <param name="str">The string to check if it's a palindrome</param>
        internal static void chkPalindrome(string str)
        {
            /* input:-madam; output:-Palindrome
            * input:-step on no pets;output-Palindrome
            * input:-book; output-Not Palindrome
            * 
            * */

            //Removes spaces as some palindromes allow for different spacing
            //IE: A nut for a jar of tuna
            str = str.Replace(" ", "");

            //Get the middle of the string for the loop
            int strLength = str.Length;
            int mid = strLength / 2;

            //If it is an empty string, it is not a palindrome
            if (strLength == 0)
            {
                Console.WriteLine("Not Palindrome");
                return;
            }
            
            //This loop will increment i under 2 conditions
            //1) i is less than the mid value
            //2) the chars at the opposite ends are equal regardless of case
            int i = 0;
            while (i < mid && (str[i] == str[strLength - i - 1] || char.ToLower(str[i]) == char.ToLower(str[strLength-i-1])))
            {
                i++;
            }

            //If i == mid, then the loop was able to go through the entire string
            //signalling that it is a palindrome.
            if (i == mid) Console.WriteLine("Palindrome");
            else Console.WriteLine("Not Palindrome");
        }

        internal static void SingleToMulti(int[] array, int row, int column)
        {
            /* input: 1,2,3,4,5,6
             * output: 1 2 3
             *         4 5 6
             * */

            int[,] array2D = new int[row, column];

            for(int i = 0; i < array.Length; i++)
            {
                //Use integer division to get current row
                //Ex: 5 / 3 = 1
                int curRow = i / column;

                //Use modulus to get current column
                //Ex: 5 % 3 = 2
                int curCol = i % column;

                //Thus, EX: array2D[1, 2] = 5
                array2D[curRow, curCol] = array[i];
            }

            //Basic for loop to display contents of the array
            for(int curRow = 0; curRow < row; curRow++)
            {
                for(int curCol = 0; curCol < column; curCol++)
                {
                    Console.Write(array2D[curRow, curCol].ToString() + " ");
                }
                Console.WriteLine();
            }
        }

        internal static bool FindPrime(int number)
        {
            /* input:-20 output:-Not Prime
             * input:-17 output:-Prime
             * 
             * */

            return false;
        }
    }
}
