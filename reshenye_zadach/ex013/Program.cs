// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int y = Convert.ToInt32(Console.ReadLine());
if(x%y==0)
{
    Console.WriteLine($" {x} кратно {y}");
}
else
{

    Console.WriteLine($"{x%y}");
}