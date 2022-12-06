// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a>99 && a<1000)
{
  Console.WriteLine( ( a / 10 )% 10 );  
}
else
{
Console.WriteLine("это не трехзначное число");
}
