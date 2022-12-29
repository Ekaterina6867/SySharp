// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());
void Number (int x)
{
    if ( x%7==0 && x%23==0) 
      {
      Console.WriteLine("число кратно 7 и 23");
      }
      else 
       {
        Console.WriteLine("число не кратно 7 и 23");
       }
}

Number(x);