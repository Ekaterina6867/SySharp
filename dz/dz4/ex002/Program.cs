//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 Console.WriteLine("введите число");
 int x = Convert.ToInt32(Console.ReadLine());
 int sum = 0;
 int num = 0;
 while (x>0)
 {
    num = x%10;
    sum = sum+num;
    x=x/10;
 }
Console.WriteLine(sum);

