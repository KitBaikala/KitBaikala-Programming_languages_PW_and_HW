// String, Char


// Console.Clear();
// Console.Write("Введите имя: ");
// string name = Console.ReadLine()!;
// Console.WriteLine(name[0]); 
// Console.WriteLine(name.Length);
// Ivan
// 0123 индексы в строке

// name = "Ivan"    String тип данных
// name[0] = 'I'    Char тип данных

// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!;
// Console.WriteLine(Convert.ToInt32(number[0])); перевод данных из char в int
// char s = '!';
// Console.WriteLine(number[0] * 2);

// '4' * 2 = "44"
// '4' * 2 = 8
// '4' -> 4


// Console.WriteLine('A' > 'a');


// Напишите программу, которая на вход принимает число и выводит сумму всех его цифр.
// int -> |2147000000|
// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!;
// // int n = int.Parse(Console.ReadLine()!);
// // char -> string -> int
// int result = 0;
// for (int i = 0; i < number.Length; i++){
//     result += int.Parse(number[i].ToString());
// }
// Console.WriteLine(result);



// Array(массивы)
// List(список)
/*
Отличия:
1. В массиве хранятся элементы одного типа данных, в то время внутри списка могут
находится одновременно элементы рахных типов данных.
2. Массив работает гораздо быстрее

data = [23, "Hello", -1.56, True] - список
import array, import numpy
int[] data = {34, 56, 90, -10}; - массив
*/


// Задание 1
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];   // [0, 0, ..., 0]
// // double[] array = new double[n]; // [0.0, 0.0, ..., 0.0]
// // string[] array = new string[n]; // ["", "", ..., ""]
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11); // [-10; 10]
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// Console.Write("Введите искомый элемент: ");
// int element = int.Parse(Console.ReadLine()!);
// string result = "Нет";
// for (int i = 0; i < array.Length; i++){
//     if (array[i] == element)
//         result = "Да";
// }
// Console.WriteLine(result);



// Задание 2
// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Console.Clear();
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11); // [-10; 10]
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// for (int i = 0; i < array.Length; i++)
//     array[i] *= -1;
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


// Задание 3
// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // [1, 10]
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int[] resultArray = new int[array.Length / 2];
// for (int i = 0; i < array.Length / 2; i++)
//     resultArray[i] = array[i] * array[array.Length - 1 - i];
// Console.WriteLine($"Конечный массив: [{string.Join(", ", resultArray)}]");


// Задание 4
// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м. 

Console.Clear();
int n = 456;
int[] array = new int[3];
array[0] = n % 10;
array[1] = (n % 100) / 10;
array[2] = n / 100;
Console.WriteLine($"[{string.Join(" ", array)}]");