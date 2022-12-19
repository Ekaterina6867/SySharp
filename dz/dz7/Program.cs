// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray (double[,] matr) // метод заполнения массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j <matr.GetLength(1); j++)
        {
           
           matr[i,j]= Convert.ToDouble(new Random().Next(0, 20)) / 10;
           
        }
       ;
    }
}

void PrintArray (double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
     for (int j = 0; j < matr.GetLength(1); j++)
     {
        Console.Write($"{matr[i,j]+"  "}");
     }  
     Console.WriteLine(  ); 
    }
}
double [,] matr  = new double [8,8];
FillArray(matr);
PrintArray(matr);