//  Показать таблицу квадратов чисел от 1 до N 


    Console.WriteLine("введите число");
    int x = Convert.ToInt32(Console.ReadLine());
    int result = 0;
        while(x>0 )
    {
        result = x*x;
        x=x-1;
        Console.WriteLine(result);
    }
    

