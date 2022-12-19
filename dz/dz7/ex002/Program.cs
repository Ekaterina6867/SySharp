// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

void FillArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,9);
        }
    }
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j] +"  "}");
        }
        Console.WriteLine();
    }
}

void Find (int[,] arr)
{
    Console.WriteLine("введите индекс строки");
    int x = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("введите индекс столбца");
    int y = Convert.ToInt32(Console.ReadLine());     
    if (x< arr.GetLength(0) && y< arr.GetLength(1)) 
    {
      for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++);
              {
                Console.WriteLine($"{arr[x,y]}");
                break;
              }
        }      
            

    }
    else
    {
        Console.WriteLine("такого элемента нет");
        
    }    
        
    }

int [,] arr = new int [3,3];
FillArray(arr);
PrintArray(arr);
Find(arr);

