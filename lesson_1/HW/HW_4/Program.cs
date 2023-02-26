// Задача 4. 
//Написать программу, которая принимает число N и выдает все четные от 1 до N

string s_n = Console.ReadLine()!;
int n = int.Parse(s_n);
int a = 2;

while (a <= n)
{
  Console.Write(a);
  a = a + 2;
}
