
 public static class myLybrary
{
   public static int[ ]CreateArray (int count)
 {
  return new int[count];
 }

 public static void Fill(int[] array)
 {
  for (int i = 0; i < array.Length; i++)
  {
    array[i]=Random.Shared.Next(0,15);    
  }

 }

public static string Print(int[] array)
{
    return String.Join(' ',array);
}
public static  int Pow(int a, int b)
{
    int result=1;
    for (int i = 0; i < b; i++)
    {
      result=result*a;
    }
    return result;
}
 

 public static int ToDec(int[] value)
 {
  int result=0;
  int count=value.Length;
  for (int i = 0; i < value.Length; i++)
  {
    result+=value[i]*Pow(15, count-1-i);
  }
  return result;
 }
}
