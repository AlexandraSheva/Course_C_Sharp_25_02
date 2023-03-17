// Задача 3. Написать программу, которая задает массив из 8 элементов случайными числами и выводит их на экран

void Print(int[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]}");
  Console.WriteLine();
}

int[] EightMass(int size, int from, int to)
{
  int[] arr = new int[size];

  for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(from,to);

  return arr;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num, start, stop);
Print(mass);