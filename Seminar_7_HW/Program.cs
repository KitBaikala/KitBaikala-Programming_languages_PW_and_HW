﻿// Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


//  Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Console.Clear();
// Console.Write("Введите число M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine());
// AkkermanFunction(m, n);

// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n));
// }
// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

string NumbersFor(int a, int b)
{
string result = String.Empty;
for (int i = a; i >= b; i--)
{
result += $"{i} ";
}
return result;
}
string NumbersRec(int a, int b)
{
if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
else return String.Empty;
}
Console.WriteLine(NumbersFor(-16, 10)); // 10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec(-1, 10)); // 10 9 8 7 6 5 4 3 2 1