
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
    Console.WriteLine(new string('*', i));
}

Console.ReadKey();