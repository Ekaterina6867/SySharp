// методы


void Method1()
{
    Console.WriteLine("текст");
}
Method1();

// методы, которые ничего не возвращают, но могут принимать аргументы
void Method21 (string msg, int count)  
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
 Method21("текст", 4);



 int Method3 ()
 {
    return DataTime.Now.Year;
 }
 int year = Method3;
 Console.WriteLine(year);


 //методы которые что-то принимают и что-то возвращают

 string Method4 (int count, string c)
 {
    int i = 0;
    int result = String.Empty; // переменная, в которую будем класть конечный результат, пустая строка
    while (i<count)
    {
        result=result+c;
        i++;
    }
    return result; //переменная, значение которой мы ожидаем получить из метода
 }

 string res = Method4(10, text);
 Console.WriteLine(res);





string Method41 (int count, string c)
 {
    
    int result = String.Empty; // переменная, в которую будем класть конечный результат, пустая строка
    for (int i = 0; i < length; i++)
    {
        result=result+c;
    }
    
    return result; //переменная, значение которой мы ожидаем получить из метода
 }

 string res = Method41(10, text);
 Console.WriteLine(res);