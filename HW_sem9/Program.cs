// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
if (A>B)
{
    Console.WriteLine("Первое число должно быть меньше второго, попробуйте еще раз.");
}
Console.WriteLine("Числа от " + A + " до " + B);
for (int i = A; i <= B; i++)
{
    Console.Write(i + " ");
}

// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число А");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// if (A>B)
// {
//     Console.WriteLine("Первое число должно быть меньше второго, попробуйте еще раз.");
// }
// Console.WriteLine("Сумма чисел от " + A + " до " + B);
// int sum = 0;
// for (int i = A; i <= B; i++)
// {
//     sum = sum + i; 
// }
// Console.Write(sum);

// Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) =  9
//int m = InputNumbers("Введите m: ");
//int n = InputNumbers("Введите n: ");

// int Aсkerman = Ack(m, n);

// Console.Write($"Функция Аккермана = {Aсkerman} ");
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else if (n == 0 && m > 0)
//         return Akkerman(m - 1, 1);
//     else
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
// }
// Console.Write(Akkerman(m, n));
