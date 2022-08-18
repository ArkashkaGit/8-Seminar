/*
Задача 58: 
Задайте две матрицы. 
Напишите программу, 
которая будет находить произведение двух матриц.

Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1   20  56  10
20  81  8   6
56  8   4   24
10  6   24  49
*/
int[,] array = new int[5, 3];
int[,] array2 = new int[5, 3];

// Метод создающий рандомный массив
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

System.Console.WriteLine("Создан перый рандомный двумерный массив:");
array = RandomArray(array);
System.Console.WriteLine("Создан второй рандомный двумерный массив:");
array2 = RandomArray(array2);

// Метод создающий новый массив 
// из произведения матриц двух входящих массивов
int[,] GenerationTwoMatrix(int[,] array, int[,] array2)
{
    int[,] generationTwoMatrix = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0) && i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) && j < array2.GetLength(1); j++)
        {
            generationTwoMatrix[i, j] = array[i, j] * array2[i, j];
        }
    }
    return generationTwoMatrix;
}

// метод выводящий двумерный массив в терминал
void OutPutArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


System.Console.WriteLine("Произведения матриц двух массивов:");
OutPutArray(GenerationTwoMatrix(array, array2));