/*
Задача 54: 
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/


int[,] array = new int[5, 5];

// Метод создания рандоиного массива.
int[,] RandomArray(int[,] array)
{
    System.Console.WriteLine("Создан рандомный двумерный массив:");
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
// Метод сортировки двумерного массива построчно.
int[,] SortLineArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int min = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = min;
                }
            }
        }
    }
    return array;
}
// Метод вывода массива на экран.
void OutPutArray(int[,] array)
{
    System.Console.WriteLine("Создан отсортированный двумерный массив построчно:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


array = RandomArray(array);
array = SortLineArray(array);
OutPutArray(array);



