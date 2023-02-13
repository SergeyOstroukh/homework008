// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] FillMultidimensionalArray(int x, int y, int z, int min, int max)
{
    Random rnd = new Random();
    int[,,] matrix3D = new int[y, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matrix3D[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }

    return matrix3D;
}

void PrintMatrixRnd3D(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                if (k < matrix3D.GetLength(2) - 1)
                    Console.Write($"{matrix3D[i, j, k],2} ({i},{j},{k})  ");
            }

        }
    }
}




int[,,] mtr = FillMultidimensionalArray(2, 2, 2, 1, 10);
PrintMatrixRnd3D(mtr);
