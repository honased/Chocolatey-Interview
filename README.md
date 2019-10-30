# Chocolatey-Interview
For the Chocolatey Interview, I was tasked with solving three out of the five problems they provided. As such, this repository contains a C# Console Application that contains the methods to solve those three problems. The program also has a demo to show off the methods and sections where the user can input their own data to test the methods within the application. All code is documented and should be easy to read, understand, and modify.

## Methods
### Palindrome
This method, chkPalindrome(string str), displays whether a given string is a palindrome.

**Interesting To Note**

* There is a debate to whether an empty string ("") is a palindrome. For this program, it will not be considered a palindrome.
* After some optimization, the method is able to process 899,991 in around 3 ms (best case) and 6 ms (worst case). However, that will always depend upon the computer.


### 1d to 2d Array Conversion
This method, SingleToMulti(int[] array, int row, int column), takes a 1d array of ints [1, 2, 3, 4, 5, 6], converts it into a 2d array based on the given row and column parameters, and displays the output.

*Example*
[1, 2, 3, 4, 5, 6]

Rows: 2

Columns: 3

Output:

1 2 3

4 5 6

**Interesting To Note**

* The method **will not** work up to a certain array size as that would use too much memory. An error will be printed out in this case.
* The method **will** work with row and column parameters that are too small, but a warning will be displayed, and not all data will be maintained.
* Any negative numbers will immediately cause the program to end.
* Using zero for either row or column will not break the program, but obviously no data will be outputted as no data can be contained in a 2d array with a zero size.

### Prime Number Check
This method, FindPrime(int number), determines if the given number is prime and returns a resulting boolean value.

**Interesting To Note**

* As discussed on https://en.wikipedia.org/wiki/Prime_number, the method was optimized by only checking up to the square root of the number.
* It is also optimized by immediately returning false if the number % 2 is 0 as any even number (beyond 2) can't be prime.
* Determining that 27644437 was prime using the method took less than a millisecond, but that is variable to the computer.
* This method will slow down quite a bit as the number being checked increases, but that is to be expected. The amount of time it takes to find a prime number is what makes them so good in data encryption/security.

## Final Remarks
Feel free to download and tinker with any of the code. I would be interested in seeing these methods fully tested to their extent.

Finally, thank you to Chocolatey for providing me with the opportunity to interview with their company.
