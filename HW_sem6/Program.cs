// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[123];
int size = array.Length;

int count = 0;

for (int i=0; i<size; i++)
{
    array[i] = new Random().Next(0, 100);

    if (array[i] >=10 && array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine($"Наш массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Количество числе от 10 до 99: {count}");
// -------------------------------------------------------------------
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Console.WriteLine("Задайте размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// int lastIndex = array.Length - 1;
// int [] finalArray = new int[array.Length/2 + array.Length % 2];
// for (int i=0; i<size; i++)
// {
//     array[i] = new Random().Next(1, 10);
// }
// Console.WriteLine($"Наш массив: [{String.Join("; ", array)}]");
// for (int index = 0; index < finalArray.Length; index++ )
// {
//     finalArray[index] = array[index] * array[lastIndex - index];
//     if (index == lastIndex - index)
//     {
//         finalArray[index] = array[index];
//     }
//     Console.WriteLine($"{finalArray[index]} ");
// }