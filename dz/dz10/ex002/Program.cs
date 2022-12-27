// // Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
 void Sum (int m, int n)
 {
    if (m<n )
    {
    int summa = 0 ;
        for (int i = m; i < n; i++)
    {
       
        summa=((m + n) / 2) * (n - m + 1);
        
              
        
    }
        Console.Write($"сумма элементов от {m} до {n} равна {summa}" );
    }
        else Console.WriteLine("ошибка");
    
 }
 Sum(4,8);