// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Prod(int a)
{
    int count=1;
    int Production=1;
    while (count<=a)
    {
        Production *=count;
        count++;
    }
    return Production;
}
Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Prod(num));