// Задача 2. Задать значения М и N. Написать программу, которая найдет сумму натуральных элементов 
//в промежутке между М и N с помощью рекурсии. 

int Sum(int M, int N)
{
  if (M == N) return M;
  return N + Sum(M, N - 1);
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(num_1, num_2));