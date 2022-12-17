//Даны два числа. Показать большее и меньшее число

Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int y = Convert.ToInt32(Console.ReadLine());
if(x>y) Console.WriteLine($"{x}-максимальное, а {y}-минимальное");
else Console.WriteLine($"{y}-максимальное, а {x}-минимальное");
