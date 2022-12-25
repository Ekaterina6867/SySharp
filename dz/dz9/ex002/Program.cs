// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 9);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j] + " "}");
        }
        Console.WriteLine();
    }
}
int Sum(int[,] array, int i)
{
    int summ = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        summ += array[i, j];
    }
    return summ;
}

void MinRow(int[,] array)
{

    int minSum = 0;
    int summa = Sum(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = Sum(array, i);
        if (summa > tempSumLine)
        {
            summa = tempSumLine;
            minSum = i;
        }
        
Console.WriteLine($"{minSum+1} - строкa с наименьшей суммой элементов ({summa})  ");
break;
    }
}
int[,] arr = new int[5, 3];
FillArray(arr);

MinRow(arr);
PrintArray(arr);
