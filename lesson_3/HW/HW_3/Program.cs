// Задача 3. Написать программу, которая принимает на вход число N и выдает таблицу кубов 
// кубов чисел от 1 до N

void Cube(int num)
{
  int i=1;
  Console.WriteLine($"{num}->");
  while (num>=i)
  {
    Console.WriteLine(i * i * i + ", ");
    i++;
  }
  Console.WriteLine();
}

int N = int.Parse(Console.ReadLine()!);
Cube(N);