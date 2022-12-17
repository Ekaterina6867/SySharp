//  4. Найти максимальное из трех чисел

Console.WriteLine("введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>a) 
{
   max=b; 
}
if (c>a) 
{
   max=c; 
} 
Console.WriteLine(max);

