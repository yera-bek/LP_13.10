// 1 Отразить на консоли надпись "Введите число" 
// 2 Проверить введенную строку является ли оно числом
// 3 Сохранить введенное число в переменную
// 4 Выяснить является ли число чётным
// 5 Вывести ответ "да" или "нет"


Console.WriteLine("Add number: ");
int a = Convert.ToInt32(Console.ReadLine());

// bool isOdd = a % 2 > 0;
// Console.WriteLine($"Is odd - {isOdd}");

if (a % 2 > 0)
{
    Console.WriteLine("Nope");
}
else 
{
    Console.WriteLine("Yeap");
}