/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
*/

Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int res = 1;

for (int i = 0; i < b; i++)
{
    res = res*a; 
}

Console.WriteLine($"{res}");


