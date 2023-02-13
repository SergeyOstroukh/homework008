// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrix(int rows, int colums, int min, int max)
{
    int[,] arrayMatrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            arrayMatrix[i, j] = rnd.Next(min, max);
        }
    }
    return arrayMatrix;
}

void PrintArrayMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array.GetLength(1)-1) Console.Write($"{array[i,j],4} ");
            else Console.Write($"{array[i,j],4}");
        }
        Console.Write(" ]");
        Console.WriteLine();

    }

}

void SortedRowsMaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                int temp;
                if (array[i, j] < array[i,k]) continue;
                temp = array[i, j];
                array[i, j] = array[i,k];
               array[i,k] = temp;
            }
        }
    }
}




int[,] creat = CreateMatrix(3, 4, 1, 50);
PrintArrayMatrix(creat);
Console.WriteLine();
SortedRowsMaxToMin(creat);
PrintArrayMatrix(creat);



