// Найти третью цифру числа или сообщить, что её нет


int n = 654454883;
int a = (int)Math.Floor(Math.Log10(n))-2;

int b = (int)Math.Pow(10,a);
Console.WriteLine(n/b%10);
