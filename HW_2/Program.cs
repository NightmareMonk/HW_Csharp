using System;

class Program
{
    static void Main()
    {
    
    Console.Write("Введите 1-ое число ");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("Введите 2-ое число ");
    int num2 = int.Parse(Console.ReadLine());
    Console.Write("Введите 3-ое число ");
    int num3 = int.Parse(Console.ReadLine());
    int max = 0;
    if (num1 > max) max = num1;
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;
    Console.Write("Максимальное " + max);
    }
}