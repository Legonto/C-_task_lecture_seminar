// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
    Console.WriteLine ("Число " + num1 + " больше чем " + num2);
}
if (num1==num2)
{
    Console.WriteLine ("Вы ввели два одинаковых числа");
}
else
{
    Console.WriteLine ("Число " + num2 + " больше чем " + num1);
}

// --------------------------------------------------------------------------------

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine ("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите третье число");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int numMax=num1;
// if (numMax<num2)
// {
//     numMax=num2;
// }
// if (numMax<num3)
// {
//     numMax=num3;
// }
// Console.WriteLine ("Большее число " + numMax);

//-----------------------------------------------------------------------------------------------

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine ("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// {
//     Console.WriteLine ("Ваше число четное");
// }
// else
// {
//     Console.WriteLine ("Ваше число не четное");
// }

//--------------------------------------------------------------------------------------------
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine ("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int i=2;
// if (num>i)
// {
//     Console.WriteLine ("Четные числа до вашего числа");
//     while (i<=num)
//     {
//         if (i % 2 == 0)
//         {
//             Console.WriteLine (i + " ");
//             i++;
//         }
//         else
//         {
//             i++;
//         }
//     }
// }
// else
// {
//     Console.WriteLine ("Введите число больше 1");
// }