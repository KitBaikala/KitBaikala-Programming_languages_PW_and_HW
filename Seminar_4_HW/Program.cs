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


// Задача 3. Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Масив: ");
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

// решение второй задачи из примера: 
// Задача 2: Подсчет количества четных чисел в массиве
// using System;
// class Program
// {
//     static void Main()
//     {
//         int[] numbers = new int[10]; // Массив для хранения случайных чисел
//         Random random = new Random(); // Генератор случайных чисел
//         int evenCount = 0; // Счетчик четных чисел
//                            // Заполнение массива случайными трехзначными числами
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000); // Случайное число от 100 до 999
//             Console.Write(numbers[i] + " "); // Вывод сгенерированного числа
//                                              // Проверка на четность и увеличение счетчика
//             if (numbers[i] % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }
//         // Вывод количества четных чисел в массиве
//         Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
//     }
// }


// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

// using System;
 
// public class Example
// {
//     public static void Main()
//     {
//         int[] array = { 5, 6, 4, 5, 9, 10 };
//         int[] numbers = array;
//         Console.Write("Исходный массив: ");
//         foreach (int number in numbers)
//          {
//              Console.Write(number + " ");
//          }
//         Array.Reverse(array);
 
//         Console.Write("\nПеревернутый массив: ");
//         Console.WriteLine(String.Join(',', array));
//     }
// }
// Решение рабочее

// Решение 3 задачи из примера
// Задача 3: Реверсирование одномерного массива

// using System;
// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 1, 3, 5, 6, 7, 8 }; // Исходный массив
//         int temp;
//         // Вывод исходного массива
//         Console.Write("Исходный массив: ");
//         foreach (int number in numbers)
//         {
//             Console.Write(number + " ");
//         }
//         // Реверсирование массива
//         for (int i = 0; i < numbers.Length / 2; i++)
//         {
//             // Меняем местами элементы
//             temp = numbers[i];
//             numbers[i] = numbers[numbers.Length - 1 - i];
//             numbers[numbers.Length - 1 - i] = temp;
//         }
//         // Вывод измененного массива
//         Console.Write("\nПеревернутый массив: ");
//         foreach (int number in numbers)
//         {
//             Console.Write(number + " ");
//         }
//     }
// }
// рабочее решение