
/* 
Input: integer n (size – must be odd)
Example: n = 9
    *    
   ***   
  *****  
 ******* 
*********
 ******* 
  *****  
   ***   
    *    
*/




/// <summary>
/// - Draws a diamond shape in the console.
/// - Number(input) must be positive Odd number.
/// - Do while loop allows user to draw unlimited amount of diamonds until user exits program. using (x).
/// - User will be notified of invalid input and program continues. 
/// </summary>






string input = "";
do
{
  Console.WriteLine();
  Console.WriteLine("Please enter an odd number for a perfect Diamond (or 'x' to exit).");
  input = Console.ReadLine() ?? "";

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

  // Top half of Diamond.

  for (int i = 1; i <= n - 1; i++)
  {
    for (int j = n ; j >= 1; j--)
    {
      if (i >= j && i % 2 != 0)
      {
      Console.Write("* ");
      }
      else
      {
        Console.Write(" ");
      }
      
    }
    Console.WriteLine();
  }

  // Bottom half of diamond.

  for (int k = n; k >= 1; k--)
  {
    for (int l = n ; l >= 1; l--)
    {
      if (k >= l && k % 2 != 0)
      {
      Console.Write("* ");
      }
      else
      {
        Console.Write(" ");
      }
      
    }
    Console.WriteLine();
  }
} while (true);
