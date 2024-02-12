/*
Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.

Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
и показывает наибольшую цифру числа.

Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
а на выходе показывает его цифры через запятую.
*/

// Задача 1
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n % 7 == 0 && n % 23 == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// Задача 2
// Console.Clear();
// Console.Write("Введите X: ");
// int x = int.Parse(Console.ReadLine()!);
// while (x == 0){
//     Console.Write("Вы ошиблись!\nВведите X: ");
//     x = int.Parse(Console.ReadLine()!);
// }
// Console.Write("Введите Y: ");
// int y = int.Parse(Console.ReadLine()!);
// while (y == 0){
//     Console.Write("Вы ошиблись!\nВведите Y: ");
//     y = int.Parse(Console.ReadLine()!);
// }
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");


// Задача 3

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 10 || n > 99){
//     Console.Write("Введите число из диапазона [10; 99]: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// // 56, 78, 13
// int n1 = n / 10;
// int n2 = n % 10;
// // 56 : 10 = 5(ост. 6)
// if (n1 > n2)
//     Console.WriteLine(n1);
// else
//     Console.WriteLine(n2);


// Задача 4
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// // 5239   ->   5, 2, 3, 9
// int count = 0, x = n;
// // n = 5239
// // n = n / 10 = 5239 : 10 = 523
// while (x > 0){
//     x /= 10; // x = x / 10;
//     count++;
// }
// // 5239 = 5*10^3 + 2*10^2 + 3*10^1 + 9*10^0
// for (int i = count - 1; i >= 0; i--){ // n = 5329
//     int m = n / Convert.ToInt32(Math.Pow(10, i)); // m = 5329 / 10.0^3 = 5
//     n %= Convert.ToInt32(Math.Pow(10, i)); // n = 5329 % 1000 = 329
//     if (i != 0)
//         Console.Write($"{m}, ");
//     else
//         Console.Write(m);
// }



// Функции и процедуры(методы???)

// методы это понятие допустимо только в ООП.


// Простая процедура
// void f(){
//     Console.WriteLine("Hello, world!");
// }


// Console.Clear();
// f();
// f();
// f();

// Процедура принимает аргументы
// void f(ref int n){
//     n = n + 5;
// }


// int n = 10;
// // f(n); передача аргумента по значению
// f(ref n);
// Console.WriteLine(n);


// Функции
// Выведите наибольшее число среди 2-х
// string maxDouble(int x, int y){
//     if (x > y)
//         return "Первое число больше второго";
//     // x <= y
//     return "Второе число больше или равно первого";
// }
// // return - возвращает значение откуда была вызвана функция!!!!
// // return - моментально завершает работу функции!!!!
// string result = maxDouble(12, 18);
// Console.WriteLine(result);
// Console.WriteLine(maxDouble(-1, 5));
// Console.WriteLine(maxDouble(134, 8));
// Console.WriteLine(maxDouble(-89, 56));


// Задание 1
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// void inputArray(int[] array){ // передача происходит по ссылке
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 1001); // [1, 1000]
// }

// bool isPrime(int x){
//     for (int i = 2; i <= x / 2; i++){
//         if (x % i == 0)
//             return false;
//     }
//     return true;
// }

// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int count = 0;
// foreach (int element in array){  // ТАКИМ ОБРАЗОМ НЕЛЬЗЯ ИЗМЕНИТЬ ЭЛЕМЕНТЫ МАССИВЫ!!!
//     if (isPrime(element) == true)
//         count++;
// }
// Console.WriteLine(count);



// Задача 2
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 1001); // [1, 1000]
// }

// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int count = 0;
// foreach (int element in array){
//     if (element % 10 == 1 && element % 7 == 0)
//         count++;
// }
// Console.WriteLine(count);


// Задача 3
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.


void inputArray(int[] array){
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10); // [0, 9]
}


int createNumber(int[] array){
    int resultNumber = 0, count = array.Length - 1;
    for (int i = 0; i < array.Length; i++){
        resultNumber += array[i] * Convert.ToInt32(Math.Pow(10, count));
        // resultNumber = 0 + 4 * 10^4 = 40000
        // resultNumber = 40000 + 9 * 10^3 = 49000
        // resultNumber = 49000 + 9 * 10^2 = 49900
        // resultNumber = 49000 + 0 * 10^1 = 49900
        // resultNumber = 49000 + 1 * 10^0 = 49901
        count--;
    }
    return resultNumber;
}

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = int.Parse(Console.ReadLine()!);
while (n > 8){
    Console.Write("Вы ошиблись!\nВведите кол-во чисел: ");
    n = int.Parse(Console.ReadLine()!);
}
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// 55944115 - 8 цифр
// 5*10^7 + 5*10^6 + 9*10^5... + 5*10^0
Console.WriteLine(createNumber(array));