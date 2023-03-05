// Задача 3. Написать программу, которая задает массив из 8 элементов случайными числами и выводит их на экран

void Array(int num)
{
  int[] Ar = new int[num];
  for(int i=0;i<num;i++)
  {
    Ar[i]=new Random().Next(10);
    Console.WriteLine(Ar[i]);
  }
}

Array(8);