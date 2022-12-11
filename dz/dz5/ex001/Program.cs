// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] col) //метод заполнения массива
{
    int length = col.Length;
    int index = 0;
    while (index<length)
    {
        col[index]=new Random().Next(100,999);
        index++;
    }
}

void PrintArray(int[]col) //метод печати массива
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
     Console.WriteLine(col[position]);
     position++;
    }
}


void Find (int[] col)
{
    int count = col.Length;
    int index = 0;
    int find =0;

        while (index<count)
    {
        if(col[index]%2==0)
        find=find+1;
        index++;
    }
    
    
Console.WriteLine("итого четных чисел:");
Console.WriteLine(find);

}
int[]array=new int [10];
FillArray(array);
PrintArray(array);

Find(array);

