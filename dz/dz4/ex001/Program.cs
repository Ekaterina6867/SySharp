// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.WriteLine("введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите первое число");
int y = Convert.ToInt32(Console.ReadLine());
int K = 0;
int b = 1;
while (K!=y)
{
K++;
b*=x;
}
Console.WriteLine(b);
