//  По двум заданным числам проверять является ли одно квадратом другого

void Square(int a, int b)
{
   
    if (b * b == a)
    {
        Console.WriteLine($"число {a} является квадратом {b} ");
    }
    else Console.WriteLine($"число {a} не является квадратом {b} ");
}
    Console.WriteLine("введите число x");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число y");
    int y = Convert.ToInt32(Console.ReadLine());
Square(x,y);
