/*
Input: single integer n (height)
Example: n = 6
1
22
333
4444
55555
666666*/

Console.WriteLine("Please enter the height of the desired triangle.");
Console.WriteLine("example: 5");

int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
  for (int j = 1; j <= i; j++)
  {
    Console.Write(i);
  }
  Console.WriteLine();
}
