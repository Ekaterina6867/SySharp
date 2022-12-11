// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void CreateArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index<length)
    {
        arr[index]=new Random().Next(1,10);
        index++;
    }
}

void PrintArray (int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while(index<length)
    {
        Console.WriteLine(arr[index]);
        index++;
    }
}

void Summ (int[] array)
{
    int length = array.Length;
    int index = 0;
    int summa=0;
    while(index<length)
    {
        if(index%2==0)
        summa=summa+array[index];
        index=index+1;

    }
    Console.WriteLine("сумма элементов с четным индексом:");
    Console.Write(summa);
}



int[]array=new int [10];
CreateArray(array);
PrintArray(array);
Summ(array);