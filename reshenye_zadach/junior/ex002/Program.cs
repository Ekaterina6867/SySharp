//21. Программа проверяет пятизначное число на палиндромом.
void Palindrome(int a)
{
    int b = a % 10;
    int c = a / 10000;
    int d = (a / 10) % 10;
    int e = (a / 1000) % 10;
    if(a>9999 && a<100000)
    {
    if (b == c && d == e) Console.WriteLine($"число {a} - палиндром");
    else Console.WriteLine($"число {a} - не палиндром");
    }
    else Console.WriteLine("неверное число");
}
Console.WriteLine("введите пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());
Palindrome(x);