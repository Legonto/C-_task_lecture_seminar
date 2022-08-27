// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine ("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = Math.Abs(num);
// if (num1 >= 100 && num1 <= 999)
// {
//     num1 = num1 / 10 % 10;

//     Console.WriteLine ("Второе число " + num1);
// }
// else
// {
//     Console.WriteLine ("Вы ввели не трехзначное число");
// }

//-------------------РЕШЕНИЕ 2 ЕСЛИ ВСЕ В STRING ПЕРЕВОДИТЬ-----------------------------

// Console.WriteLine ("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100)
// {
//     Console.WriteLine ("Вы ввели не трехзначное число");
// }
// else 
// {
// string textnum = Convert.ToString(num);
// Console.WriteLine ("Второе число " + textnum[1]);
// }

//-------------------------------------------------------------------------------------------------------

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6 


// Console.WriteLine ("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = Math.Abs(num);
// if (num1 >= 100 && num1 <= 999)
// {
//     num1 = num1 % 10; Console.WriteLine ("Третье число " + num);    
// }
// else
// {
//    Console.WriteLine ("Третьей цифры нет"); 
// }
// if (num1 > 999)
// {
//     while (num1 > 999)
//     {
//         num = num / 10;
//     }
//     num1 = num1 % 10; Console.WriteLine ("Третье число " + num);
// }

//-------------------РЕШЕНИЕ 2 ЕСЛИ ВСЕ В STRING ПЕРЕВОДИТЬ----------------------------

// Console.WriteLine ("Введите число");
// string textnum = Console.ReadLine();
// if (textnum.Length > 2)
// {
//    Console.WriteLine ("Третье число " + textnum[2]); 
// }
// else
// {   
//     Console.WriteLine ("Третьего числа нет ");
// }
// 

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine ("Введите число дня недели");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >=1 && num <=7)
// {
//     if (num == 6 | num == 7)
//     {
//         Console.WriteLine ("Сегодня выходной");
//     }
//     else 
//     {
//         Console.WriteLine ("Сегодня рабочий день");
//     }
// }
// else
// {
//     Console.WriteLine ("Вы ввели не день недели");
// }
//---------------------------------------------------------------
Console.WriteLine("Введите день недели");
Dictionary<int, string> Days = new Dictionary<int, string>()
{
    {1, "Понедельник, рабочий день"},
    {2, "Вторник, рабочий день"},
    {3, "Среда, рабочий день"},
    {4, "Четверг, рабочий день"},
    {5, "Пятница, рабочий день"},
    {6, "Суббота, выходной"},
    {7, "Воскресенье, выходной"},
};
int index = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Days[index]);