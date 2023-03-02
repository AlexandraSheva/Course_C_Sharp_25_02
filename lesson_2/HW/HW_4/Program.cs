// Задача 4. Написать программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день недели выходным.


void Week(int a)
{
  if (a == 1)
  {
    Console.WriteLine("Будний");
  }
  else if (a == 2)
  {
    Console.WriteLine("Будний");
  }
  else if (a == 3)
  {
    Console.WriteLine("Будний");
  }
  else if (a == 4)
  {
    Console.WriteLine("Будний");
  }
  else if (a == 5)
  {
    Console.WriteLine("Будний");
  }
  else if (a == 6)
  {
    Console.WriteLine("Выходной");
  }
  else if (a == 7)
  {
    Console.WriteLine("Выходной");
  }
  else
    Console.WriteLine("Не день недели");

}
Week(int.Parse(Console.ReadLine()));