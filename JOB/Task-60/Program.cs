/*
Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, 
которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

int[,,] array = new int[3, 3, 3];

// Метод создающий рандомный трёхмерный массив
// с не повторяющимися двузначными значениями
int[,,] RandomArray3D(int[,,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(10, 100);

                for (int n = 0; n < array.GetLength(0); n++)
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                    {
                        for (int q = 0; q < array.GetLength(2); q++)
                        {
                            if (array[i, j, k] == array[n, m, q])
                            {
                                array[i, j, k] = rnd.Next(10, 100);
                            }
                        }
                    }
                }
            }
        }
    }
    return array;
}
// Метод выводящий трёхмерный массив в терминал
// с индексом значения
int[,,] IndexArray3D(int[,,] array)
{
    System.Console.WriteLine("Вывод трёхмерного массива с неповторяющимися значениями \nи указанными индексами каждого значения:");
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("-------------------------------");
    }
    return array;
}

System.Console.WriteLine();
RandomArray3D(array);
IndexArray3D(array);