Console.WriteLine("Add num: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;

Console.WriteLine((Multipule(num, a) && Multipule(num, b)) ? "yeap" : "nope");

bool Multipule(int first, int second)
{
    return first % second == 0;
}