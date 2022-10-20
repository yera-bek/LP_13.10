// 1 Отразить на консоли надпись "Введите первое число" 
// 2 Проверить введенную строку является ли оно числом
// 3 Сохранить введенное число в переменную
// 4 Отразить на консоли надпись "Введите второе число"
// 5 Проверить введенную строку является ли оно числом
// 6 Сохранить введенное число в переменную
// 7 Сравнить две переменные 
// 8 Вывести ту переменную число которой оказалось больше

Console.WriteLine("Add first number: ");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);
Console.WriteLine("Add second number: ");
string c = Console.ReadLine();
int d = Convert.ToInt32(c);

if (b > d)
{
    Console.WriteLine($"{b}");
}
else
{
    Console.WriteLine($"{d}");
}
