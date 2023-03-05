// Задача 2. Написать программу, которая принимает на вход число и выдает сумму цифр в числе
//Тут не понимаю, как вывести так, чтобы складывались все цифры. Пробовала в num и num/10 и num%10

int SumNum(int num)
{
  int kol = 0;
  while ( num > 0)
  {
    num = num / 10;
    kol = kol + num;
  }
  return kol;
}

int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(A));