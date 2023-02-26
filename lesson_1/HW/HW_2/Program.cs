// Задача 2. 
//Написать программу, которая принимает три числа и выдает максимальное из них.

// Программа работает некорректно. Почему, не понимаю. Вместо наибольшего значения выдает среднее. 
// Хотя по условиям должна выдавать максимальное

string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;
string s_c = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);

if (a > b || a > c)
{
  Console.WriteLine(a);
}
else if (a < b || b > c)
{
  Console.WriteLine(b);
}
else if (a > c || b < c)
{
  Console.WriteLine(c);
}
