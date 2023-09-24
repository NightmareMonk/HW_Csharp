using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int remain = num % 2;
if (remain == 0)
{
        Console.WriteLine("четное");
}
else
{
        Console.WriteLine("нечетное");
}
    }
}