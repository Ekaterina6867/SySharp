using static System.Console;

/// <summary>
/// Это библиотека для работы с массивами
/// <para> Метод создания массива - CreateArray </para>
/// <para> Метод Заполнения массива - Fill </para>
/// </summary>
public static class MyLibrary123
{
  /// <summary>
  /// Метод создания массива
  /// </summary>
  /// <param name="count">Количество элементов нового массива</param>
  /// <returns>Созданный массив из count элементов</returns>
  public static int[] CreateArray(int count)
  {
    return new int[count]; // new int[count];
  }

  public static void Fill(int[] array, int min, int max)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = Random.Shared.Next(min, max);
      //array[i] = new Random().Next(min, max);
    }
  }

  // 3. Метод печати массив ПЛОХОЙ
  public static void PrintBad(int[] array)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      WriteLine($"{array[i],3}");
    }
    WriteLine();
  }

  // 3. Метод печати массив !ПЛОХОЙ
  public static string PrintGood(int[] array)
  {
    string output = String.Empty;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      output += $"{array[i],3}";
    }
    return output;
  }


  /// <summary>
  /// cscscsdcsd  
  /// cscscsdcsd
  /// <para>cscscsdcsd</para>
  /// <para>cscscsdcsd</para>
  /// </summary>
  /// <param name="array"></param>
  /// <param name="down"></param>
  /// <param name="up"></param>
  /// <returns></returns>
  public static int Counter(int[] array, int down, int up)
  {
    int result = 0;

    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      if (array[i] >= down && array[i] <= up)
      {
        result++;
      }
    }

    return result;
  }

  public static int Input(string text)
  {
    Console.Write(text);
    return int.Parse(ReadLine());
  }
}