﻿using System;

class Program
{
    static void Main()
    {
    
    Console.Write("Введите 1-ое число ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите 2-ое число ");
    int b = int.Parse(Console.ReadLine());
    Console.Write("Введите 3-ое число ");
    int c = int.Parse(Console.ReadLine());
    int max = 0;
    if (a > max) max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    Console.Write("Максимальное " + max);
    }
}