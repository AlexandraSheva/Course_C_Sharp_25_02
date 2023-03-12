// 1.1 Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

void Trngl(int A, int B, int C)
{
  if (A < B + C && B < A + C && C < A + B)
    Console.WriteLine($"Да");

  else
    Console.WriteLine($"Нет");
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
int num_3 = int.Parse(Console.ReadLine()!);
Trngl(num_1, num_2, num_3);

