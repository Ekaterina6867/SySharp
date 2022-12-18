// . Показать вторую цифру трёхзначного числа
Console.WriteLine("введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());
if ( x<999 && x>99)
{
    int y = (x/10)%10; // делим на 10, т.е отбрасываем последнее число, а потом берем остаток от деления на десять.
Console.WriteLine(y);
}
else
{
 Console.WriteLine("числло не трехзначное");
}