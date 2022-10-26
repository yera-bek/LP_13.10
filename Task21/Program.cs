/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/


Console.WriteLine("Input the coordinates of point A");
Console.WriteLine("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the coordinates of point B");
Console.WriteLine("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1,y1,z1,x2,y2,z2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    double dist = Math.Sqrt(Math.Pow((xc2-xc1), 2)+Math.Pow((yc2-yc1), 2)+ Math.Pow((zc2-zc1), 2));
    return dist;
}