// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,]array)//заполняем масив рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
           array[i,j] = new Random().Next(1,9);
        }
    }

}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j] + " "}");
        }
        Console.WriteLine();
    }
}

void SrArf (int[,] arr) // метод нахождения среднего арифметического
{
    
     for (int j = 0; j <arr.GetLength(1); j++)
     {
        double summ=0;
    
         for (int i = 0; i < arr.GetLength(1); i++)
         {    
         summ=summ+arr[i,j];
              

         }
         Console.WriteLine($"среднее арифметическое {j} строки { summ / arr.GetLength(0)} ");
     }
    
}



int [,]array = new int  [2,4];
FillArray(array);
PrintArray(array);
SrArf(array);
