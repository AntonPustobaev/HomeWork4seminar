//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

using System;
Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;
Console.Write($"{num} -> ");

while (num > 0)
{
    int digit = num % 10;
    sum = sum + digit;
    num = num / 10;
}

Console.WriteLine(sum);