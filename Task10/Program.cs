//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления)

Console.WriteLine("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = RemoveFirstAndLastDigit(num);
Console.WriteLine(result);

int RemoveFirstAndLastDigit(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
   return (num - (firstDigit * 100 + secondDigit)) / 10;
}