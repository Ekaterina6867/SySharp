// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.WriteLine("введите первое число");
double x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
double y = Convert.ToInt32(Console.ReadLine());
double K = 0;
double b = 1;
while (K!=y)
{
K++;
b*=x;
}
Console.WriteLine(b);
