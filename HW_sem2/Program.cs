// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine ("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    num = num / 10 % 10;

    Console.WriteLine ("Второе число " + num);
}
else
{
    Console.WriteLine ("Вы ввели не трехзначное число");
}

//-------------------РЕШЕНИЕ 2 ЕСЛИ ВСЕ В STING ПЕРЕВОДИТЬ-----------------------------

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

// if (num >= 100 && num <= 999)
// {
//     num = num % 10; Console.WriteLine ("Третье число " + num);    
// }
// else
// {
//    Console.WriteLine ("Третьей цифры нет"); 
// }
// if (num > 999)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     num = num % 10; Console.WriteLine ("Третье число " + num);
// }

//-------------------РЕШЕНИЕ 2 ЕСЛИ ВСЕ В STING ПЕРЕВОДИТЬ----------------------------

// Console.WriteLine ("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// string textnum = Convert.ToString(num);
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