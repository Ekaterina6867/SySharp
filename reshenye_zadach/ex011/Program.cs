//  Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("введите число от 10 до 99 включительно");
int x = Convert.ToInt32(Console.ReadLine());
while( x<100 && x>9)
{
        int y = x%10;
    int c = x/10;
    if(y>c)
    {
        Console.WriteLine(y);
        break;

    }
    else
    {
        Console.WriteLine(c);
        break;
    }
}
    
