
/* 
Input: single integer n (side length)
Example: n = 6
******
*    *
*    *
*    *
*    *
******
*/

Console.WriteLine("Please enter the side length of box.");
Console.WriteLine("example: 6");

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
  for (int j = 0; j < n; j++)
  {
    if (i == 0 || i == n -1 || j == 0 || j == n -1)
    {
      Console.Write("*");      
    }
    else
    {
      Console.Write(" ");
    }
  }
  Console.WriteLine();
}



/*
Explanation:
inside the inner loop we have an if statement with some rules.
If (i == 0) meaning if its the first row || (i == n -1) our last row - 1 because we start from 0.
This defines the top and bottom of our Rectangle.

Then we do same for the sides to define left and right of our Rectangle.¨

when those contidions are met we log "*"  else we log empty " ". 
This gives us our desired hollow Rectangle.
 

*/