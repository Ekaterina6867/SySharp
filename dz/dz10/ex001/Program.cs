﻿// // Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число больше 1:");
int x = int.Parse(Console.ReadLine());


void recursia (int x)
{
    if (x < 0) Console.Write($"{x} не натуральное число");
    if (x == 0) return;
    Console.Write(x);
    recursia (x - 1);
}

recursia(x);