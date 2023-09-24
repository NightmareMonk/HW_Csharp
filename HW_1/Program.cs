using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a + " большее");
    Console.Write(b + " меньшее");
}

else if (a == b)

{
    Console.WriteLine(a + " равно " + b);
}
else
{
    Console.WriteLine(b + " большее");
    Console.WriteLine(a + " меньшее");
}

    }
}