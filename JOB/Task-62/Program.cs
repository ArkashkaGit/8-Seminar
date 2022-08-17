/*
Задача 62. 
Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1   2   3   4
12  13  14  5
11  16  15  6
10  9   8   7
*/
int[,] array = new int[4, 4];

// Метод создания рандомного массива.
int[,] RandomArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return array;
}
// Метод спиральной сортировки двумерного массива 4 на 4
int[,] SpiralSortArray4x4(int[,] array)
{
    int[] massifeSort = new int[array.GetLength(0) * array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            massifeSort[count] = array[i, j];
            count++;
        }
    }

    for (int i = 0; i < massifeSort.Length; i++)
    {
        for (int j = 0; j < massifeSort.Length; j++)
        {
            if (massifeSort[i] < massifeSort[j])
            {
                int min = massifeSort[i];
                massifeSort[i] = massifeSort[j];
                massifeSort[j] = min;
            }
        }

    }

    array [0,0] = massifeSort[0];   array [0,1] = massifeSort[1];  
    array [0,2] = massifeSort[2];   array [0,3] = massifeSort[3];  
    array [1,3] = massifeSort[4];   array [2,3] = massifeSort[5];
    array [3,3] = massifeSort[6];   array [3,2] = massifeSort[7];  
    array [3,1] = massifeSort[8];   array [3,0] = massifeSort[9];  
    array [2,0] = massifeSort[10];  array [1,0] = massifeSort[11];
    array [1,1] = massifeSort[12];  array [1,2] = massifeSort[13];
    array [2,2] = massifeSort[14];  array [2,1] = massifeSort[15];

    return array;
}
// метод вывода двумерного массива в терминал
void OutPutArray(int[,] array)
{
    System.Console.WriteLine("--------------------------------");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

RandomArray(array);
SpiralSortArray4x4(array);
OutPutArray(array);