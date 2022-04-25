//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;
Console.Clear();
Console.Write("Введите длину массива: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(String.Join(" ", SetArray(N)));

int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(100);
    }
    return arr;
}