Console.WriteLine("Add first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add second number: ");
int bsecond = Convert.ToInt32(Console.ReadLine());

bool CheckSquareNumber(int first, int second)
{
    return first * first == second || second * second == first;
}

bool CheckSquareNumber=CheckSquareNumber(first, second);

Console.Write(CheckSquareNumber ? "yeap" : "nope");