// Задача 1: Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. Программа завершается 
// при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// using System;
// class Program
// {
//     static void Main()
//     {
//         while (true) // Бесконечный цикл
//         {
//             Console.Write("Введите число или 'q' для выхода: ");
//             string input = Console.ReadLine(); // Чтение строки ввода пользователя
//             if (input == q) // Проверка на ввод 'q' для выхода
//             {
//                  break;
//             }
//             int number;
//             if (int.TryParse(input, out number)) // Проверка, является ли ввод числом{
//                 int sum = 0;
//             while (number > 0) // Вычисление суммы цифр числа
//             {
//                 sum += number % 10; // Добавление последней цифры к сумме
//                 number /= 10; // Удаление последней цифры из числа
//             }
//             if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
//             {
//                 Console.WriteLine("[STOP]");
//                 break;
//             }
//         }
//         while // Если ввод не является числом и не 'q', повторить запрос
//         {
//             Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
//         }
//     }
// }


// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.WriteLine("Введите массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Масиив: ");
// PrintArray(numbers);
// int count = 0;

// for (int x = 0; x < numbers.Length; x++)
// if (numbers[x] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Рабочее решение


