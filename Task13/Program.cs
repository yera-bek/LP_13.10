/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).*/

Console.WriteLine("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);

if (IsNumberHasThirdDigit(num))
{
    while (num > 1000)
    {
        num = num / 10;
    }
    Console.Write($"{num%10}");
}
else
{
    Console.Write("The third digit is missing");
}

bool IsNumberHasThirdDigit(int number)
{
    if (number / 100 > 0)
    {
        return true;
    }
    return false;
}