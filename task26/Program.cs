// Задача 26: Напишите программу, которая принимает на вход число
//  и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число:");
int a=Convert.ToInt32(Console.ReadLine());

if (a<0) a=-a;

string b=Convert.ToString(a);
 
int X=b.Length;

Console.WriteLine("Длина вашего числа составляет " + X);
