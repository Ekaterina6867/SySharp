// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("введите число от одного до семи");

int n = int.Parse(Console.ReadLine()!);
;

if (n>0 && n<6)
{
    Console.WriteLine("нет, не выходной");
}
else if (n>5 && n<8)
{
    Console.WriteLine("да, выходной");
}
else
{
    Console.WriteLine("введите число от 1 до 7");
}