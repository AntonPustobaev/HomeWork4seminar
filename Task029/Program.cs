﻿//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;
Console.Clear();

int N = 8;

int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
}

PrintArray(SetArray(N));