// Показать четные числа от 1 до N

Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    if(i%2==0)
    {
        Console.WriteLine(i);
        
    }
}