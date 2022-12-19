//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]= Convert.ToDouble(new Random().Next(0, 20)) / 10;
        }
        
    }
}

void PrintArray(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]+"  "}");
    }
      Console.WriteLine();
   }
}

double [,] array = new double [5,3];
FillArray(array);
PrintArray(array);
