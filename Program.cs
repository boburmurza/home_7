// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
// double[,] Great2Array(int n, int m, int min, int max)
// {
//     double[,] array = new double[n, m];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().NextDouble() * (max-min);
//         }
//     }
//     return array;
// }

// void Show2Array(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(array[i,j],1)+" ");
//         }
//            Console.WriteLine();
//     }

// }
// Console.Write(" enter number of m:= ");
// int m =  Convert.ToInt32(Console.ReadLine());
// Console.Write(" enter number of n:= ");
// int n =  Convert.ToInt32(Console.ReadLine());
// Console.Write(" enter number of min elem:= ");
// int min =  Convert.ToInt32(Console.ReadLine());
// Console.Write(" enter number of max elem := ");
// int max =  Convert.ToInt32(Console.ReadLine());

// double[,]array = Great2Array(n,m,min,max);
// Show2Array(array);


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int[,] Great2Array(int n, int m, int min, int max)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void Show2Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }


// }
// void Operation(int[,] array, int i, int j)
// {
//     if (i < array.GetLength(0) && j < array.GetLength(1))
//         Console.Write($" значение этого элемента :=  {array[i,j]}");
//     else
//         Console.Write($" такого числа в массиве нет  {array[i,j]}");

// } 

// Console.Write(" enter number of m:= ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write(" enter number of n:= ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(" enter number of min elem:= ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write(" enter number of max elem := ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write(" enter number of elemnet i:= ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write(" enter number of elemnet j:= ");
// int j = Convert.ToInt32(Console.ReadLine());
// int[,] array = Great2Array(n, m, min, max);
// Show2Array(array);
// Operation(array, i, j);
//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] Great2Array(int n, int m, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }


}
void Operation(int[,] array)
{
     for (int j = 0; j< array.GetLength(1); j++){
       
        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
          summ = summ+array[i,j];
    
        }
       Console.WriteLine($"Среднее арифметическое №{j} столбца: {Math.Round((summ/array.GetLength(0)),1)} ");
    }

} 

Console.Write(" enter number of m:= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" enter number of n:= ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" enter number of min elem:= ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" enter number of max elem := ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write(" enter number of elemnet i:= ");

int[,] array = Great2Array(n, m, min, max);
Show2Array(array);
Operation(array);