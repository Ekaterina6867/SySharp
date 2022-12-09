public static class myLybrary
{
    //1.метод создания массива

    public static int[] CreateArray(int count)
    {
        return new int []; // new int [count]
    }


//2. метод который заполняет массив

public static void Fill (int[] array)
{
    int size = array.Length;
}

//2.1 метод заполнения массива с min и  max

public static void FillArray (int [] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i>size; i++)
    {
        array[i] = Random.Shared.Next(min,max);
    }
}
}

