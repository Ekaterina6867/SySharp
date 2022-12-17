// Показать числа от -N до N
Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = -x; i <= x; i++)
{
    Console.WriteLine(i);
}
