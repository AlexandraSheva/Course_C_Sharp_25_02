// Задача 2. Написать программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3Д-пространстве.

double Example(double x1, double x2, double y1, double y2, double z1, double z2)
{
  return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
}


Console.WriteLine(Example(1,-3,7,8,-5,-2));
