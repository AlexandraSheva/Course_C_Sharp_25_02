// 4. Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.


int Stepen(int A, int B)
{
  if (B == 0) return 1;
  return Stepen (A, B-1)*A;
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(Stepen(num_1, num_2));