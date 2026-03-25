
/* 
Input: odd integer n (size of the X)
Example: n = 7
*     *
 *   *
  * *
   *
  * *
 *   *
*     *
*/




/// <summary>
/// - Draws a (X) shape in the console.
/// - Number(input) must be positive Odd number.
/// - Do while loop allows user to draw unlimited amount of (X) until user exits program. using (e).
/// - User will be notified of invalid input and program continues. 
/// 
/// We have (i) which jumps one row through each iteration. Console.WriteLine().
/// we have (j) which loops through whole columns with each (i) iteration. using Console.Write().
/// amount of iteration is decided by the userInput (n).
/// 
/// Creating X:
/// (Left to right) j == i
/// 
/// In the inner loop we check where the (i) is same as (j) and print (*) through each iteration and empty space where condition is not met. 
/// For (j), (i) will be different in each row, because (i) increments until it meets userInput (n).
/// This will create the the line that goes fromleft to right. moving new spot through each iteration. 
/// 
/// (Right to left) n - 1 - i
/// 
/// So here we do the opposite: We start from (n) userInput.
/// We have (n - 1) to solve the fact that we start counting from 0 in programming.
/// Since (i) grows through each iteration, subtracting it from a fixed number is like a countdown.
/// the result decrements each row until it reaches 0, creating the line that goes from right to left.
/// </summary>

string input = "";
do
{
  Console.WriteLine();
  Console.WriteLine("Please enter an odd number to create (X) shape. (or 'x' to exit app).");
  input = Console.ReadLine()?.ToLower() ?? "";

  if (input == "x")
  {
    Console.WriteLine("Bye!");
    break;
  }

  if (!int.TryParse(input, out int n) || n <= 0 || n % 2 == 0)
  {
    Console.WriteLine("Invalid input. Please enter a positive odd number.");
    continue;
  }

  // Logic for X shape.
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n; j++)
    {
      if (i == j || j == n - 1 - i) {
        Console.Write("*");
      }
      else
      {
        Console.Write(" ");
      }
    }
    Console.WriteLine();
  }
} while (true);
