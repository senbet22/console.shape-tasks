
/* 
Input: single integer n (height of the triangle)
Example: n = 5
    *
   **
  ***
 ****
*****
*/

Console.WriteLine("Please enter the height of the desired triangle.");
Console.WriteLine("example: 5");

int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
  for (int j = n; j >= 1; j--)
  {
    if (j <= i)
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
The outer loop is responsible for jumping to new line after each iteration.
The inner loop iterates completely everytime outerloop runs to new line.

Key part:
The inner loop counts backwards. also since we are using Console.Write it counts sideways or rows. 
so in first row it checks if inner loop (j) <= outerloop (i). and since in this case thats not true it will print " ".
The loop keeps going to next and the next. in the last row when j <= i. it will print "*"
*/
