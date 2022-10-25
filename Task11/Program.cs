int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int finalNumber = RemoveSecondDigit(num);
Console.WriteLine(finalNumber);

int RemoveSecondDigit(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
   return firstDigit * 10 + secondDigit;
}