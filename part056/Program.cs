// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            if (array[i, j] < array.GetLength(1) - 1) Console.Write($"{array[i, j],4} ");
            else Console.Write($"{array[i, j],4}");
        }
        Console.Write(" ]");
        Console.WriteLine();

    }

}

int[] SumElementsInRows(int[,] array)                    
{
    int[] arrayMatr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumElements = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElements = sumElements + array[i, j];

        }
        arrayMatr[i] = sumElements;
        sumElements = 0;
    }
    return arrayMatr;
}

int RowsIndexWithMaxSumNumbers(int[] array)
{
    int minNumber = 0;
    int indexNumberMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        minNumber = array[0];
        if (array[i] < minNumber)
        {
            minNumber = array[i];
            indexNumberMin = i;
        }
    }
    return indexNumberMin;
}


int[,] create = CreateMatrix(4, 3, 1, 50);
PrintArrayMatrix(create);
Console.WriteLine();
int[] sumElements = SumElementsInRows(create);
RowsIndexWithMaxSumNumbers(sumElements);
Console.WriteLine();
int rowsIndex = RowsIndexWithMaxSumNumbers(sumElements);
Console.WriteLine($"{rowsIndex+1} строка имеет наименьшую сумму всех элементов");
