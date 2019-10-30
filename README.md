# Chocolatey-Interview
For the Chocolatey Interview, I was tasked with solving three out of the five problems they provided. As such, this repository contains a C# Console Application that contains the methods to solve those three problems. The program also has a demo to show off the methods and sections where the user can input their own data to test the methods within the application. All code is documented and should be easy to read, understand, and modify.

## Methods
### Palindrome
This method, chkPalindrome(string str), displays whether a given string is a palindrome.

**Interesting To Note**

* There is a debate to whether an empty string ("") is a palindrome. For this program, it will not be considered a palindrome.
* After some optimization, the method is able to process 899,991 in around 3 ms (best case) and 6 ms (worst case). However, that will always depend upon the computer.
* The method will ignore spaces and letter case since the following sentence 'A nut for a jar of tuna' is a palindrome.
  * However, it will not ignore non-numeric and non-alphabetic characters ('"' or '#'). It wouldn't be difficult to implement, but it once again gets into a debate about what is and isn't a palindrome.
  * So, for the purposes of this method and simplicity's sake, '#dad#' is considered a palindrome whereas '#dad' is not.


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
  * This error could have potentially been ignored by just printing out the 1d array in a '2d' display, but I thought it would be more useful to actually convert it into a 2d array. That way, if the 2d array ever needed to be returned, all one would have to do is add a return statement.
* The method **will** work with row and column parameters that are too small, but a warning will be displayed, and not all data will be maintained.
* Using 0 or a negative number for either the # of rows or the # of columns will display an error and end the method.
  * This is because no data could ever be stored in an array with less than 1 column or row.

### Prime Number Check
This method, FindPrime(int number), determines if the given number is prime and returns a resulting boolean value.

**Interesting To Note**

* As discussed on https://en.wikipedia.org/wiki/Prime_number, the method was optimized by only checking up to the square root of the number.
* It is also optimized by immediately returning false if the number % 2 is 0 as any even number (beyond 2) can't be prime.
* Determining that 27644437 was prime using the method took less than a millisecond, but that is variable to the computer.
* This method will slow down quite a bit as the number being checked increases, but that is to be expected. The amount of time it takes to find a prime number is what makes them so good in data encryption/security.
  * One could potentially use the [Sieve of Eratosthenes](https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes) to determine if a number is prime, but not only would that give us more data than we want, but it would also only work well on smaller numbers due to the nature of the method.
  
## Demo
As stated in the introduction, this program features a 'demo' to show off each method. For each method, the program shows some built in cases, and then allows the user to input their own data to try it out. All inputted data is validated so that theoretically, the user cannot break the program. This demo section was not at all required for the interview, but I thought it would be interesting to allow anybody to try out the functions without having to write any code. If, while editing the code, you want to stop seeing the demo, there is a boolean at the top of the *Main* method called *demoMode* that controls if the demo is run.

## Final Remarks
Feel free to download and tinker with any of the code. I would be interested in seeing these methods fully tested to their extent.

Click [here](https://trello.com/b/2K1Fybrj) to view the Trello board I used while working on the interview.

Finally, thank you to Chocolatey for providing me with the opportunity to interview with their company.
