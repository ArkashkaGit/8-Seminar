/*
Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 
1 строка
*/
int[,] array = new int[6,6];

// Метод создающий рандомный массив
int[,] RandomArray(int[,] array)
{
    System.Console.WriteLine("Создан массив с рандомными числами:");
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

// Метод который находит строку, с наименьшей суммой  
void LineMinSumma(int[,] array)
{
    System.Console.Write("Номер строки с наименьшей суммой: ");
    int minSummLine = 0;
    int sumMinLine = 0;
    int summ = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
            if (j == array.GetLength(1)-1)
            {
                if(i == 0)
                {
                    sumMinLine = summ;
                    minSummLine = 1;
                }
                else if (summ < sumMinLine)
                {
                    sumMinLine = summ;
                    summ = 0;
                    minSummLine = i + 1;
                }
                else
                {
                summ = 0;
                }
            }
        }
    }
    System.Console.Write(minSummLine);
}

LineMinSumma(array = RandomArray(array));
