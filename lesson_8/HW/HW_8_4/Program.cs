// Задача 4. Задчать две матрицы. Написать программу, которая будет находить произведение двух матриц



void Print(int[,] arr)
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

int[,] MassNums(int row, int column, int from, int to)
{
  int[,] arr = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      arr[i, j] = new Random().Next(from, to + 1);

  return arr;
}

int[,] ProductMat(int[,] arr_1, int[,] arr_2)
{
  int row_1 = arr_1.GetLength(0);
  int column_1 = arr_1.GetLength(1);

  int row_2 = arr_2.GetLength(0);
  int column_2 = arr_2.GetLength(1);

  int[,] pr_mat = new int[row_1, column_1];

  if (column_1 != row_2) return pr_mat;
  else if (column_1 == row_2)
    pr_mat = new int[row_1, column_2];

  for (int i = 0; i < row_1; i++)
  {
    for (int j = 0; j < column_2; j++)
    {
      for (int p = 0; p < column_1; p++)
        pr_mat[i, j] += arr_1[i, p] * arr_2[p, j];
    }
  }
  return pr_mat;
}

Console.WriteLine("Введите количество строк матрицы 1: ");
int row_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок матрицы 1: ");
int column_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк матрицы 2: ");
int row_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок матрицы 2: ");
int column_2 = int.Parse(Console.ReadLine()!);


int[,] arr_1 = MassNums(row_1, column_1, 1, 10);
Print(arr_1);
int[,] arr_2 = MassNums(row_2, column_2, 1, 10);
Print(arr_2);

int[,] result_matrix = ProductMat(arr_1, arr_2);
Print(result_matrix);