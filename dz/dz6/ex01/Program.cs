// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("введите числа через пробел");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
int size = 0;
for (int i = 0; i < array.Length; i++)
{
    if ( array[i] > 0)
    {
        size++;
    }

    
}
Console.WriteLine($"Количество элементов > 0: {size}");