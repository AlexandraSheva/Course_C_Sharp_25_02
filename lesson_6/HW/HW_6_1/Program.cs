// Задача 1. Пользователь вводит с клавиатуры М чисел. 
//Посчитать, сколько чисел больше нуля ввел пользователь. 

//Предположим, пользователь вводит четыре числа

void Pos (int num_1, int num_2, int num_3, int num_4)
{
  int col = 0;
  if (num_1>0)
  col++;
  if(num_2>0)
  col++;
  if(num_3>0)
  col++;
  if(num_4>0)
  col++;
  Console.Write($"{col}");
}

int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int C = int.Parse(Console.ReadLine()!);
int D = int.Parse(Console.ReadLine()!);

Pos(A,B,C,D);
