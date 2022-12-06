// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Pol(int number)
{
    if(number >= 10000)
    {
        int n = number / 10000;
        int x = number % 10;
 
            if(n == x)
            {
                number = number / 10;
                int n1 = (number / 100) % 10;;
                int x1 = number % 10;
                if(n1 == x1)
                    Console.WriteLine("Да");
            }
            else 
            Console.WriteLine("Нет");
            
    }
    else
    Console.WriteLine("Некорректное число");
}
 
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
Pol(number);
