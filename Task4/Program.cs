
/* 
Input: single integer n (height of the pyramid)
Example: n = 5
    *
   ***
  *****
 *******
*********

*/

Console.WriteLine("Please enter the height of the desired triangle.");
Console.WriteLine("example: 5");

int n = int.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
  for (int j = n; j >= 1; j--)
  {
    if (i >= j)
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

/*
This time everytime i >= j we get the * and " " space. 
Because the star and space take double the amount of space, it pushes the shape in both directions leading to centered triangle.
*/