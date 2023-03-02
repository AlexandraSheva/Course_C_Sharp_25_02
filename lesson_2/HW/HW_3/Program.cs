// Задача 3. Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int Find(int num)
{
  if (num < 100)
  {
    Console.WriteLine("Нет третьего числа");
  }
  else if (num > 99 && num < 1000)
  {
    Console.WriteLine(num % 10);
  }
}

int result = Find(int.Parse(Console.ReadLine()));
Console.WriteLine(result);

