﻿// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число");
int a=Convert.ToInt32(Console.ReadLine());
int count=1;
int Production=1;
while (count<=a)
{
    Production *=count;
    count++;
}
Console.WriteLine(Production);