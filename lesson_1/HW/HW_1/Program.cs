//Задача 1.
//Написать программу, которая принимает два числа и на выходе выдает, какое наибольшее, а какое – наименьшее

string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);

if (a > b)
{
  Console.WriteLine(a + "=max");
}
else if (a < b)
{
  Console.WriteLine(b + "=max");
}
else
{
  Console.WriteLine("Error");
}
