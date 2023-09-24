using System;

class Program
{
     static void Main()
    {
        Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine(+ num1 + " большее");
    Console.Write(+ num2 + " меньшее");
}

else if (num1 == num2)

{
    Console.WriteLine(+ num1 + " равно " + num2);
}
else
{
    Console.Write(+ num2 + " большее");
    Console.Write(+ num1 + " меньшее");
}

    }
}   