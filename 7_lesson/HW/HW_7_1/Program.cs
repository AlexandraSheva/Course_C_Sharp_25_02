// Задача 1. Задать двумерный массив, заполненный случайными вещественными числами.

void Print(double[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
      Console.Write($" {arr[i, j]} ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

double[,] MassNums(int row, int column, int from, int to)
{
  double[,] arr = new double[row, column];
  Random n_new = new Random();

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      arr[i, j] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);

  return arr;
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

double[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);