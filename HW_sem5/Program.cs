// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int countEvenNumber = 0;
int index  = 0;
while (index < size)
{
    array[index] = new Random().Next(100,1000);
    index++;
}
for (int startIndex = 0; startIndex < size; startIndex++)
if (array[startIndex] % 2 == 0)
    {
        countEvenNumber++;
    }
Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"Количество четных чисел = {countEvenNumber}");
//--------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Задайте размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// int i = 0;
// int sumOddIndex = 0;
// while (i < size)
// {
//     array[i] = new Random().Next(-99,100);
//     i++;
// }
// for (int index = 1; index < size; index = index + 2)
// {
//     sumOddIndex = sumOddIndex + array[index];

// }
// Console.WriteLine($"[{String.Join("; ", array)}]");
// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sumOddIndex}");
//-------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.WriteLine("Задайте размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(1,100);
// }
// double maxNumber = array[0];
// double minNumber = array[0];

// for (int index = 1; index < size; index++)
// {
//     if (maxNumber < array[index])
//     {
//         maxNumber = array[index];
//     }
//     if (minNumber > array[index])
//     {
//         minNumber = array[index];
//     }
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {maxNumber - minNumber}");