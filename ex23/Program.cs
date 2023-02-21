﻿/***************************************************************************************

Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

***************************************************************************************/


/***************************************************************************************

Предисловие

Вариант решения №1

Если понимать условие буквально, то при отрицательном N, например -3,
кубы нужно считать для чисел от +1 до -3 ——> 1, 0, -1, -2, -3.

    | Моё решение выполнено согласно этому условию.

Ответ для N = -3 выглядел бы так: 1, 0, -1, -8, -27.
Ответ для N = 0 выглядел бы так: 1, 0.

***************************************************************************************/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    for (int i = 1; i <= num; i++)
    {
        if (i < num)
        {
            Console.Write(Math.Pow(i, 3) + ", ");
        }
        else
        {
            Console.Write(Math.Pow(i, 3) + ".");
        }
    }
}
else
{
    for (int i = 1; i >= num; i--)
    {
        if (i > num)
         {
            Console.Write(Math.Pow(i, 3) + ", ");
        }
        else
        {
            Console.Write(Math.Pow(i, 3) + ".");
        }
    }
}

Console.WriteLine();


/***************************************************************************************

Вариант решения №2

При отрицательном N, например -3,
кубы нужно считать для чисел от -1 до -3 ——> -1, -2, -3.

    | Тогда по этому условию, если N = 0 ——> "Неверное значение N".

***************************************************************************************/

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 0)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         if (i < num)
//         {
//             Console.Write(Math.Pow(i, 3) + ", ");
//         }
//         else
//         {
//             Console.Write(Math.Pow(i, 3) + ".");
//         }
//     }
// }
// else if (num < 0)
// {
//     for (int i = -1; i >= num; i--)
//     {
//         if (i > num)
//         {
//             Console.Write(Math.Pow(i, 3) + ", ");
//         }
//         else
//         {
//             Console.Write(Math.Pow(i, 3) + ".");
//         }
//     }
// }
// else 
// {
//     Console.Write("Неверное значение N");
// }

// Console.WriteLine();