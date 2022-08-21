// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i = 0; 
while (i < B)
{
    result = result * A;
    i++;
} 
Console.WriteLine(result);

// не получилось функцией сделать, ошибку выдавало, потом попробую
//------------------------------------------------------------

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = num;  i > 0; i /= 10)
// {
//     sum += i % 10;
// }
// Console.WriteLine("Сумма числа " + num + " равна " + sum);

//---------------------------------------------------------------------------------
// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// int[] arr;
// Console.WriteLine("Введите количество элементов в массиве");
// int  N = Convert.ToInt32(Console.ReadLine());
// arr = new int [N];
// Random q = new Random();
// for (int i = 0; i < N; i++)
// arr[i] = q.Next(1, 100);
// Console.WriteLine($"[{String.Join("; ", arr)}]");

