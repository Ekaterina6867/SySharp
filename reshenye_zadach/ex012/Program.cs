﻿// Удалить вторую цифру трёхзначного числа

Console.WriteLine("введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());
int y=x%10; // первая цифра с конца
int z=(x/10)%10; // вторая цифра трехзначного числа
int r = ((x/10)/10)%10;//третья цифра с конца
if ( x<999 && x>99)
{
   Console.WriteLine($"{r}{y}");
 
}
