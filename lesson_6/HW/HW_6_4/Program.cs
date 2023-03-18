// Задача 4 (из семинара). Написать программу, которая будет создавать
//копию заданного массива с помощью поэлементного копирования. 

void Print(int[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
  Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
  int[] arr = new int[size];

  for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(from, to);
  return arr;
}

void Copy(int[] arr)
{
  int[] newArr = new int[arr.Length];

  for (int i = 0; i < arr.Length; i++)
  {
    newArr[i] = arr[i];
  }

}


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Copy(mass);
Print(mass);



