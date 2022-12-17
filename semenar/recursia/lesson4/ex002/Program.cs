// See https://aka.ms/new-console-template for more information
 void PrintArray(int[,] matrix) //метод, который будет печатать массив
 {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          Console.Write($"{matrix[i,j]}");
        }
    }
    Console.WriteLine();
 }

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);// заполнение массива рандомными числами от [1 до 10)
        }
    }
}

int [,] array = new int [3,4];
PrintArray(array);
FillArray(array);
Console.WriteLine();
PrintArray(array);