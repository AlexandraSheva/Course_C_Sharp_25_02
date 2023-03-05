// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.

int ProductNum(int num)
{
  int all_prod = 1;
  for (int i = 1; i <= num; i++)
    all_prod *= i;

  return all_prod;
}

int A = int.Parse(Console.ReadLine()!);
int result = ProductNum(A);
Console.WriteLine(result);
