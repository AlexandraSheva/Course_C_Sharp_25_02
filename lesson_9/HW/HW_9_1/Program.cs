// Задача 1. Задать М и N. Написать программу, которая выведет
// все четные натуральные числа в промежутке от М до N с помощью рекурсии. 

void ValuesSet(int M, int N)
{
  if (N == M || N < M) return;
  if (N % 2 == 0)
    ValuesSet(M, N - 2);
  else ValuesSet(M, N - 1);
  Console.Write($"{N} ");
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
ValuesSet(num_1, num_2);