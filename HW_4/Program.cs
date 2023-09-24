using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int i = 2;

while (num >= i)
{
    Console.Write(i + " ");
    i = i + 2;
}
    }
}