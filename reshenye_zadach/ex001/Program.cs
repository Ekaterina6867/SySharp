// по двум заданным числам проверить является ли первое квадратом второго

Console.WriteLine("ведите число");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите второе число");
int x = Convert.ToInt32(Console.ReadLine());
if (y==x*x)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}

