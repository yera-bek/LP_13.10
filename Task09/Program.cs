int num = new Random().Next(10, 100);
Console.WriteLine($"Random number from dip 10 - 99 -> {num}");

int firstDigit = num / 10; // 78 / 10 = 7
int secondDigit = num % 10; // 78 % 10 = 8

int res = firstDigit;
if(secondDigit > firstDigit) res = secondDigit;
Console.WriteLine($"Max number {num} = {res}");

int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Max number {num} = {result}");

//int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//Console.WriteLine($"Max number {num} = {secondDigit}");

Console.Write($"Max number {num} = ");
Console.Write(firstDigit > secondDigit ? firstDigit : secondDigit);

//int max = Math.Max(firstDigit, secondDigit);
//Console.WriteLine($"Max number {num} = {max}");

// int MaxDigit(int number)
// {
   // int firstDigit = number / 10; //
    // int secondDigit= number % 10;
    // return fistDigit > secondDigit ? fistDigit : secondDigit;
// }

// int num = new Random().Next(10, 100);
// Console.WriteLine($"Random number from dip 10 - 99 -> {num}");

// int MaxDigit = MaxDigit(num);
// Console.WriteLine($"Max number {num} = {MaxDigit}");



