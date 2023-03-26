// Задача 1. Задать двумерный массив из целых чисел. Написать программу, которая
// удаляет строку и столбец, на пересечении которых расположен 
// наименьший элемент

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
      arr[i, j] = new Random().Next(from, to);

  return arr;
}

int[] MinA(int[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);
  int min_num = arr[0,0];
  int[] indexes = new int[2];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < i; j++)
      if(min_num>arr[i,j])
      {
        min_num = arr[i,j];
        indexes[0] = i;
        indexes[1] = j;
      }
  }
  Console.WriteLine(arr[indexes[0],indexes[1]]);
  return indexes;
}

void Without(int[,]arr, int[] m_indexes)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < i; j++)
      if (m_indexes[0]==i||m_indexes[1]==j) continue;
      else Console.Write($"{arr[i,j],3}");
    Console.WriteLine();
  }
  Console.WriteLine();
}



Console.WriteLine("Введите количество строк массива");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок массива");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте минимальное число в массиве");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максмальное число в массиве");
int stop = int.Parse(Console.ReadLine()!);


int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
int[] ind_1 = MinA(mass);
Without(mass,ind_1);
