// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
while (n>0)
{
    int result=n*n*n;
    n = (n-1);
   Console.WriteLine(result); 
}
