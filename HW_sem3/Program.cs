// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
  CheckNumber(number);
}
else Console.WriteLine($"Введи правильное число");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("X1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Z1");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("X2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Z2");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1 - z2, 2));

// Console.WriteLine(d);

//--------------------------------------------------------------------------------------------

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//  Console.WriteLine("Введите число");
//  int N = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine($"Кубы до числа {N}");
// for (int i = 1; i<=N; i++)
// {
//     Console.WriteLine($"{i} = {i*i*i}");
// }
