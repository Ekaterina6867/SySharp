// // Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void FillArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int y = 0; y < array.GetLength(2); y++)
            {
                array[i,j,y]   = new Random().Next(10,99);
            }
        }
    }
}
void PrintArray (int [,,]array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int y = 0; y < array.GetLength(2); y++)
            {
               Console.Write($"{array[i, j, y]}({i},{j},{y}) ");
            }
        }
    }
    
}

int [,,] array = new int [2,2,2];
FillArray(array);
PrintArray(array);
