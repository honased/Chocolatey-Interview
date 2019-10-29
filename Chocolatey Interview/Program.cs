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
            Console.WriteLine("1: " + FindPrime(1));
            Console.WriteLine("2: " + FindPrime(2));
            Console.WriteLine("-7: " + FindPrime(-7));
            Console.WriteLine("20: " + FindPrime(20));
            Console.WriteLine("17: " + FindPrime(17));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("27644437: " + FindPrime(27644437));
            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds.ToString());
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

        /// <summary>
        /// Converts a 1d array to a 2d array and displays the contents to the console.
        /// </summary>
        /// <param name="array">The 1d array to be converted into a 2d array</param>
        /// <param name="row">The number of rows in the 2d array</param>
        /// <param name="column">The number of columns in the 2d array</param>
        internal static void SingleToMulti(int[] array, int row, int column)
        {
            /* input: 1,2,3,4,5,6
             * output: 1 2 3
             *         4 5 6
             * */

            /* I thought for this method that it would be more useful to have an actual 2d
             * array than just printing the contents of the array in a '2d' format. This way,
             * if the function ever needs to return the 2d array, the 2d array is already created,
             * so all I would have to do is just add a return statement.
             */

            int[,] array2D = null;

            //Basic try catch to ensure that the user isn't trying to use too much memory
            //This ensures that the program won't break
            try
            {
                array2D = new int[row, column];
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("[ERROR] The dimensions of the 2d array would be too large.\nCancelling array conversion...");
                return;
            }

            /*Ensures that the given parameters for the 2d array have enough space to actually hold all
             * the data from the original 1d array.
             * 
             * Instead of completely cancelling out of the conversion, I instead chose to issue a 
             * warning to the user and go ahead and convert the array knowing that data will be lost.
             */
            if(row*column < array.Length)
            {
                Console.WriteLine("[WARNING] The 2d array will be too small to contain all the data.\nPlease check your row/column values...");
            }

            //Using a min function to get the smallest size between the array and the row/column so that we don't look outside of the array's bounds.
            int size = Math.Min(row * column, array.Length);
            for(int i = 0; i < size; i++)
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
            for (int curRow = 0; curRow < row; curRow++)
            {
                for(int curCol = 0; curCol < column; curCol++)
                {
                    Console.Write(array2D[curRow, curCol].ToString() + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Determines if a number is prime or not.
        /// </summary>
        /// <param name="number">The number to check for primality.</param>
        /// <returns>True or false based on if the number is prime.</returns>
        internal static bool FindPrime(int number)
        {
            /* input:-20 output:-Not Prime
             * input:-17 output:-Prime
             * 
             * */

            //If the number is 2, we don't need to run the method
            if (number == 2) return true;

            //Any number less than 2 will not be prime
            if (number < 2) return false;

            //Any even number will not be prime
            if (number % 2 == 0) return false;

            //We start at 2 since prime numbers are divisible by 1,
            //and we go to the sqrt of number since that's the biggest
            //number that could potentially be a factor
            int upperBound = (int)Math.Sqrt(number) + 1;
            for(int i = 2; i <= upperBound; i++)
            {
                if (number % i == 0) return false;
            }

            //Since we haven't returned false, the number must be prime
            return true;
        }
    }
}
