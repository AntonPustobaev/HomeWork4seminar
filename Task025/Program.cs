﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
System.Console.WriteLine();

Console.Write("Введите число А: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень В: ");
int exponent = Convert.ToInt32(Console.ReadLine());

int count = 1;
int result = num;

while (count < exponent)
{
    result = result * num;
    count++;
}

System.Console.WriteLine($"{num}, {exponent} -> {result}");