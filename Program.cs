// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("First number: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Second number: ");
int number2 = int.Parse(Console.ReadLine()!);
if (number1 > number2) Console.WriteLine("First max");
    else 
    Console.WriteLine("Second max");

