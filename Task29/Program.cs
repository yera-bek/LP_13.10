/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
*/

Random rand = new Random();

int[] arr = new int[] {
    rand.Next(100), 
    rand.Next(100),
    rand.Next(100),
    rand.Next(100),
    rand.Next(100),
    rand.Next(100),
    rand.Next(100),
    rand.Next(100)};

for (int i = 0; i < arr.Length; i++)
{
    System.Console.WriteLine(arr[i]);
}
