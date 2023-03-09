//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 3: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
    if (a<b) max = b;
    if (a<c) max = c;
Console.WriteLine(max);
        

    

