// Написать цикл, который принимает на вход два числа (А и В) и возводит число А 
// в натуральную степень числа В. 

//Понимаю, что сделала задачу неверно, но не знаю, как по-другому ее еще можно решить. 

int Stepen(int num1, int num2)
{
  for (num1 > 0; num2 > 0;)
  {
    return Math.Pow(num1, num2);
  }
}
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Stepen(A,B));