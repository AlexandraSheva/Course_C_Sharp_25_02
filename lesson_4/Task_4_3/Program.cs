// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.

void Array(int num)
{
  int[] Ar = new int[num];
  for(int i=0;i<num;i++)
  {
    Ar[i]=new Random().Next(2);
    Console.WriteLine(Ar[i]);
  }
}

Array(int.Parse(Console.ReadLine()!));
