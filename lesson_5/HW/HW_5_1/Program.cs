// Задача 1. Задать массив, заполненный случайными положительными трехзначными числами.
//Написать программу, которая покажет колличество четных чисел в массиве. 


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int SumPosNeg(int[] arr)
{
    int num_2 = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0)
            num_2++;

    }
    return num_2;
}


int num = int.Parse(Console.ReadLine()!);
int start = 100;
int stop = 999;
int[] mass = MassNums(num, start, stop);
Print(mass);
Console.WriteLine (SumPosNeg(mass));

