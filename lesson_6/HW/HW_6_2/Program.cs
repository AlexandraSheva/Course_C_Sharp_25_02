// Задача 2. Написать программу, которая найдет точку пересечения двух прямых,
//заданных уравнениями y=k1*x+b1, y=k2*x+b2.
//Значения k1,b1,k2,b2 задаются пользователем

//Для начала выразим x и y.
//x=(b2-b1)/(k1-k2)
//y=k1*x+b1

void Inter(double k1, double b1, double k2, double b2)
{
  double x = (b2-b1)/(k1-k2);
  double y = k1*x+b1;
  Console.WriteLine($"({x};{y})");
}

string A1 = Console.ReadLine();
double A = Convert.ToDouble(A1);
string B1 = Console.ReadLine();
double B = Convert.ToDouble(B1);
string C1 = Console.ReadLine();
double C = Convert.ToDouble(C1);
string D1 = Console.ReadLine();
double D = Convert.ToDouble(D1);

Inter(A,B,C,D);
