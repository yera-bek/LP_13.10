// 1 Отразить на консоли надпись "Введите первое число" 
// 2 Проверить введенную строку является ли оно числом
// 3 Сохранить введенное число в переменную
// 4 Отразить на консоли надпись "Введите второе число"
// 5 Проверить введенную строку является ли оно числом
// 6 Сохранить введенное число в переменную
// 7 Отразить на консоли надпись "Введите третье число"
// 8 Проверить введенную строку является ли оно числом
// 9 Сохранить введенное число в переменную
// 10 Сравнить три переменные 
// 11 Вывести ту переменную число которой оказалось больше


Console.WriteLine("Add first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine($"{a}");
}
if (b > a && b > c)
{
    Console.WriteLine($"{b}");
}
if (c > a && c > b)
{
    Console.WriteLine($"{c}");
}