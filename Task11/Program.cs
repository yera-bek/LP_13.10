int num = new Random().Next(100, 1000);
Console.WriteLine();

int firstDigit = num / 100;
int secondDigit = num % 10;

int result = firstDigit * 10 + secondDigit;
Console.WriteLine(num);

int RemoveSecondDigit(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
   return firstDigit * 10 + secondDigit;
}