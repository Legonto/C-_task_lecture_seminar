// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GenerateArray(int t, int i)
{
    int[,] table = new int[t, i];
    Random random = new Random();
    for (int a = 0; a < t; a++)
        {
            for (int b = 0; b < i; b++)
            {
                table[a, b] = random.Next(1, 10);
            }
        }
        return table;
}
void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.WriteLine();
    }
}
int colCount = 6;
int rowCount = 5;
int[,] arr = GenerateArray(rowCount,colCount);
Console.WriteLine("Исходный массив");
PrintArray(arr);
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
   {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
        {
            if (arr[i, k] < arr[i, k + 1])
            {
                int temp = 0;
                temp = arr[i, k];
                arr[i, k] = arr[i, k + 1];
                arr[i, k + 1] = temp;
            }
        }
   }
}

Console.WriteLine("Сортировка по строкам");
PrintArray(arr);

//--------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] GenerateArray(int t, int i)
// {
//     int[,] table = new int[t, i];
//     Random random = new Random();
//     for (int a = 0; a < t; a++)
//         {
//             for (int b = 0; b < i; b++)
//             {
//                 table[a, b] = random.Next(1, 10);
//             }
//         }
//         return table;
// }
// void PrintArray(int[,] array)
// {
//     for (int a = 0; a < array.GetLength(0); a++)
//     {
//         for (int b = 0; b < array.GetLength(1); b++)
//         {
//             Console.Write(array[a, b] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int colCount = 4;
// int rowCount = 5;
// int[,] arr = GenerateArray(rowCount,colCount);
// PrintArray(arr);
// int result = 1;                
//         int temp1 = 0, temp2 = 0;      
//         for (int i = 0; i < rowCount; i++)
//         {
//             for (int j = 0; j < colCount; j++) 
//             {
//                 if (i == 0)
//                 {
//                     temp2 += arr[i, j];
//                     temp1 = temp2;       
//                 } 
//                 else { temp2 += arr[i, j]; }             
//             }
//             if (temp1 > temp2) 
//             {
//                 result = i + 1;
//                 temp1 = temp2;
//                 temp2 = 0;
//             }
//             temp2 = 0;
//         }
// Console.Write("Строка с наименьшей суммой элементов: {0}", result);

//-----------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] GenerateArray(int t, int i)
// {
//     int[,] table = new int[t, i];
//     Random random = new Random();
//     for (int a = 0; a < t; a++)
//         {
//             for (int b = 0; b < i; b++)
//             {
//                 table[a, b] = random.Next(1, 10);
//             }
//         }
//         return table;
// }
// void PrintArray(int[,] array)
// {
//     for (int a = 0; a < array.GetLength(0); a++)
//     {
//         for (int b = 0; b < array.GetLength(1); b++)
//         {
//             Console.Write(array[a, b] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] ProductMatrix(int[,] arr1, int[,] arr2)
// {
//     if (arr1.GetLength(1) != arr2.GetLength(0))
//     {
//         System.Console.WriteLine("Матрицы невозможно перемножить в таком порядке!");
//         return arr1;
//     }
//     int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
//     for (int i = 0; i < arr1.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr2.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr1.GetLength(1); k++)
//             {
//                 arr3[i, j] += arr1[i, k] * arr2[k, j];
//             }
//         }
//     }
//     return arr3;
// }
// Console.WriteLine("Введите количество строк m: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество элементов массива в строке n: ");
// int col1 = Convert.ToInt32(Console.ReadLine());
// int[,] arr1 = GenerateArray(row1,col1);
// PrintArray(arr1);

// Console.WriteLine("Введите количество строк m: ");
// int row2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество элементов массива в строке n: ");
// int col2 = Convert.ToInt32(Console.ReadLine());
// int[,] arr2 = GenerateArray(row2,col2);
// PrintArray(arr2);

// int[,] arr3 = ProductMatrix(arr1, arr2);

// Console.WriteLine("Произведение массивов: ");
// PrintArray(arr3);
