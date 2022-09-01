// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = Int32.Parse(Console.ReadLine());
int n = Int32.Parse(Console.ReadLine());
double [,] matrix = new double[m,n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] =new Random().NextDouble() * 20 - 10; 
        // тк NextDouble выдает числа от 0 до 1, решила умножить на 20 
        // и чтобы некоторые отрицательные получились, то - 10
        Console.Write("{0,6:F1}", matrix[i,j]);
    }
    Console.WriteLine();
}


//------------------------------------------------------------------
// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int [,] matrix = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write("{0,2} ", matrix[i, j]);
//             }
//             Console.WriteLine();           
//      }
// Console.WriteLine("Введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());

// if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
// {
//    Console.WriteLine("Такого числа в массиве нет");
// }
// Console.WriteLine("Ваше число из массива: " + matrix[n,m]);
//----------------------------------------------------------------
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите количество строк");
// int m = Int32.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Int32.Parse(Console.ReadLine());
// int [,] matrix = new int [m,n];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(1,10);
//         Console.Write("{0,2} ", matrix[i, j]);
//     }
//     Console.WriteLine();
// }


// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum += matrix[i, j];
//     }
//     Console.Write($"{Math.Round(sum / matrix.GetLength(0), 2)}; ");
// }

