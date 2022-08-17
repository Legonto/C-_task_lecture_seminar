// ничего не принимают и не возвращают
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// // вызывает
// Method1();

//ничего не возвращают, но могут принимать
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2("Текст сообщения");
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method21("Text", 4);
// //Method21(msg: "Text", count: 4); // способы написания
// Method21(count: 4, msg: "Text" );

// что то возвращают, но ничего не принимают

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// принимают и возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; //пустая строка лежит

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "jdfkl");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = String.Empty; //пустая строка лежит
//     for(int i = 0; i<count; i++) // благодаря for мы можем запихнуть все в 1 строку
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "jdfkl");
// Console.WriteLine(res);

// ЦИКЛ В ЦИКЛЕ

// for (int i = 2; i<=10; i++)
// {
//     for (int j = 2; j<= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }
//-------------------------------------------------------------------
// Дан текс. В тексте нужно все пробелы заменить черточками
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// string text = "Особый класс операций представляют поразрядные операции. "
// + "Они выполняются над отдельными разрядами числа. В этом плане числа рассматриваются "
// + "в двоичном представлении, например, 2 в двоичном представлении 10 и имеет два разряда, "
// + "число 7 - 111 и имеет три разряда.";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
    
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// newText = Replace(newText, 'к', 'К');
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);

//------------------------------------------------------

int[] arr = {1, 8, 5, 9, 3, 2, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++);
    {
        Console.WriteLine(array[i]);
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[i] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


