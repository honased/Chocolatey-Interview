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
            //Tests for chkPalindrome

            //Time test - Result 6 ms
            var stopwatch = new Stopwatch();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 99999; i++)
            {
                sb.Append("AAAAAAAAA");
            }
            String convertedString = sb.ToString();
            stopwatch.Start();
            chkPalindrome(convertedString);
            stopwatch.Stop();

            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds);

            //Uppercase/lowerCase test - Good
            Console.Write("Upper/Lower test [MaDdAm]: ");
            chkPalindrome("MaDdAm");

            //Even # test - Good
            Console.Write("Even Test [Maddam]: ");
            chkPalindrome("Maddam");

            //Odd # test - Good
            Console.Write("Odd Test [Madam]: ");
            chkPalindrome("Madam");

            //Check to make sure it detects false palindromes - Good
            Console.Write("False Test [Hello World]: ");
            chkPalindrome("Hello World");
            Console.Write("False Test [Chocolatey]: ");
            chkPalindrome("Chocolatey");

            //Step on no pets test - Good
            Console.Write("Regular Test [step on no pets]: ");
            chkPalindrome("step on no pets");

            //Spacing test - Good
            Console.Write("Spacing test [a nut for a jar of tuna]: ");
            chkPalindrome("a nut for a jar of tuna");

            //Empty string test - It returns a palindrome, but does that make sense?
            Console.Write("Empty string test []: ");
            chkPalindrome("");

            //Final test - Good
            Console.Write("Cumulative Test [Al lets Della call Ed Stella]: ");
            chkPalindrome("Al lets Della call Ed Stella");

            Console.ReadKey();
        }

        internal static void chkPalindrome(string str)
        {
            /* input:-madam; output:-Palindrome
            * input:-step on no pets;output-Palindrome
            * input:-book; output-Not Palindrome
            * 
            * */

            //Convert the string to lower so that uppercase doesn't effect check
            //Also, remove spaces as some palindromes allow for different spacing
            //IE: A nut for a jar of tuna
            str = str.Replace(" ", "");

            //Get the middle of the string for the loop
            int strLength = str.Length;
            int mid = strLength / 2;
            
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
