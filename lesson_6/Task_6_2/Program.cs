﻿// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.

string Convert(int num)
{
  string result = "";
  while (num > 0)
  {
    result = num % 2 + result;
    num/=2;
  }
  return result;
}

Console.WriteLine(Convert(12));

