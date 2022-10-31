/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).*/

/* 1. Взять последнюю цифру 
2. Взять первую цифру 
3. Сравнить их
4. нет: то вернуть, что число не полиндром 
да: то продолжить исполнение 
5. Удалить последнюю цифру 
6. удалить первую цифру
7. Продолжить сравнение*/  

Console.WriteLine("Enter a five-digit number: ");
int mirrow = Convert.ToInt32(Console.ReadLine());

/*
int buf = 10000;
bool isMIrrow = true;

while (buf > 0)
{
    int firstDigit = mirrow / buf;  
    int lastDigit = mirrow % 10; 
    buf = buf / 10; 
    if (firstDigit != lastDigit)
    {
        isMIrrow = false; break;
    }

    mirrow = mirrow/10;
    mirrow = mirrow - (firstDigit * buf);
    buf = buf/10;
}

if (isMIrrow)
{
    Console.WriteLine($"Is polindrome"); 
}
else{
    Console.WriteLine($"NOT polindrome"); 
}
*/

int firstDigit = mirrow / 1000;
int secondDigit =  mirrow % 100;

if (firstDigit / 10 == secondDigit % 10 && firstDigit % 10 == secondDigit / 10)
{
    Console.WriteLine("Is polindrome");
}
else 
{
    Console.WriteLine("NOT polindrome");
}
