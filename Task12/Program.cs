Console.Write("Add first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Add second number: ");
int d = Convert.ToInt32(Console.ReadLine());
if (Div(a, d))
{
    Console.Write("non");
}
else
{
    Console.Write("yeap");
}


bool Div (int first, int second)
{
    return first % second == 0;
}