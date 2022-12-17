// раскрасить массив
// 1. Определим точку внутри массива (замкнутого контура)
// 2.  Определимправила обхода ( например: вверх, в лево, вниз, в право)
int [,]pic = new int [,]; // предусмотрено, что этот массив уже задан ранее, поэтому я не могу запустить программу.

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
           if(image[i,j] == 0) Console.Write($" "); // если текущий элемент равен 0, то пишем пробел 
           else Console.WriteLine($"+"); //если не выполняется предыдущее условие, то ставим (+)
        }
        Console.WriteLine();
    }
}

void FillImage (int row, int col) // метод, чтобы закрасить массив, в скобках  позиция пикселя.
{
    if(pic[row,col] == 0 ) // если пиксель текущей строки не закрашен, т.е 0. (закрашен==1)
    {
        pic[row,col]=1; // т.е. будем закрашивать
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    } 

}


PrintImage(pic);
FillImage(13,13);
PrintImage(pic);