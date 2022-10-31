/* Write a programm
1. Takes a number (N) as input
2. Produces a spreadsheet of cubes of numbers from 1 to N
*/

Console.WriteLine("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i} | {Math.Pow(i, 3)}");
}