// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrixRnd(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrixRnd(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int rowsInA = firstMatrix.GetLength(0);
    int columnsInA = firstMatrix.GetLength(1); 
    int columnsInB = secondMatrix.GetLength(1); 

    int[,] matrix = new int[rowsInA, columnsInB];

    for (int i = 0; i < rowsInA; i++)
    {
        for (int j = 0; j < columnsInB; j++)
        {
            for (int k = 0; k < columnsInA; k++) 
            {
                matrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }

    return matrix; 
}

Console.Write("Введите количество столбцов матрицы A и число строк матрицы B: ");
int rowsColumnsAB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы A: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы B: ");
int columnsB = Convert.ToInt32(Console.ReadLine());
int[,] matrixOne = FillMatrixRnd(rowsA, rowsColumnsAB, 1, 10);
int[,] matrixTwo = FillMatrixRnd(rowsColumnsAB, columnsB, 1, 10);
int[,] matrixThree = MultiplyMatrix(matrixOne, matrixTwo);
Console.WriteLine("Матрица A:");
PrintMatrixRnd(matrixOne);
Console.WriteLine("Матрица B:");
PrintMatrixRnd(matrixTwo);
Console.WriteLine("Произведение двух матриц:");
PrintMatrixRnd(matrixThree);