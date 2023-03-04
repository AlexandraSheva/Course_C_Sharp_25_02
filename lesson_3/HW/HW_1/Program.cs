// Задача 1. Написать программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом

void Palindrome(int num)
{
  if (num > 9999 && num < 100000 && num / 10000 == num % 10 && num % 10000 / 1000 == num % 100 / 10)
  {
    Console.WriteLine("Yes");
  }
  else Console.WriteLine("No");
}

int x = int.Parse(Console.ReadLine()!);
Palindrome(x);