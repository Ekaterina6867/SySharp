// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

void CreateArray (double[] array)
{
    double length = array.Length;
    int index = 0;
    while(index<length)
    {
        array[index]=new Random().NextDouble();
        index++;
    }
}
 
 void PrintArray (double[] arr)
{
    double length = arr.Length;
    int index = 0;
    while(index<length)
    {
        Console.WriteLine(arr[index]);
        index++;
    }
}

 void Max (double[] array)
 {
    double length = array.Length;
    int index = 0;
    double max = array[0];
    double min = array[0];
        while(index<length)
    {
        if (array[index]>max)
        {
            max=array[index];
            
        }   
        
        else if (array[index]<min)
        {
            min=array[index];
        }
        index++;
    }
     
    
    Console.WriteLine("max, min:");
    Console.WriteLine(max);
    Console.WriteLine(min);
    Console.WriteLine($"{max}-{min}={max-min}");
 }

double[]array=new double[10];
 CreateArray(array);
 PrintArray(array);
 Max(array);