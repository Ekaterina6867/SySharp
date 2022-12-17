// Двумерные массивы

string[,] table = new string[2,5];
table [1,2] = "слово"; // в строке 1 столбце два будет "слово"
// table [0,0]  table [0,1]  table [0,2] .....table[0,4]
// table [1,0]  table [1,1]   table [1,2].....table[0,4]
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"-{table[i,j]}-");
    }
    Console.WriteLine();// переход на новую строчку
}