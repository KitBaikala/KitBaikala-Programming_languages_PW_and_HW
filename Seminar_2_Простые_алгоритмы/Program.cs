/*
Транслятор.
Виды трансляции:
** Компиляция
** Интерпретация


С#: int n = 5; -> []

Python: m = -10 -> class 'int' -> []
*/

/* Основные типы данных
1. integer(int) - 0, -12, 56, 90
2. double - 2.0, 56.923, -1.345
3. boolean(bool) - true, false
4. string - "Anna", "Moscow" (строка обозначается двойными кавычками)
5. char - 'a', 'c', 'e', '5' 
*/


// Принимаем данные от пользователя
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{n} + {m} = {n + m}");


/*
int m = Convert.ToInt32(Console.ReadLine());
Console.ReadLine() -> считывание данных из консоли -> ["456"]
int m = Convert.ToInt32("456"); -> [456]
int m = 456;
*/

/*
int n = int.Parse(Console.ReadLine()!);
Console.ReadLine() -> считывание данных из консоли -> ["456"]
int n = int.Parse("456") -> ["456"] -> [456]
*/

/*
Алгебра Логики(Булевская)
True(1) 
False(0)

&& - конъюнкция(логическое умножение)
|| - дизъюнкция(логическое сложение)
*/
//                  0   +   1 = 1(True)
// Console.WriteLine(5 > 7 || 3 > 2);
//                  0   *   1 = 0(False)
// Console.WriteLine(-1 > 2 && 3 > 2);
//                   1    +     0     *  1 = 1 + 0 = 1(True)
// Console.WriteLine(34 > 23 || 45 < -2 && 2 > 1);


// Найдите максимальное число из 2-х.
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// if (n > m){
//     Console.WriteLine($"{n} больше {m}");
// }
// else if (n < m)
//     Console.WriteLine($"{m} больше {n}");
// else
//     Console.WriteLine("Числа равны");

/*
if
if
7-ое условие оказалось верным!!!
....
if
if
*/
/*
if - ВСЕГДА НАЧИНАЕТСЯ
else if
else if
...
else if
*/

// Задание 1
// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Console.Clear();
// Console.Write("Введите 3-х значное число: ");
// int n = int.Parse(Console.ReadLine()!);
// // n = Math.Abs(n); // модуль числа
// while (n < 100 || n > 999){
//     Console.Write("Вы ошиблись!\nВведите 3-х значное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int n1 = n / 100;
// int n3 = n % 10;
// // 523 : 10 = 52 (ост. 3)
// // 5 * 100 + 2 * 10 + 3 * 1 = 523
// Console.WriteLine(n1 * 10 + n3);
// Console.WriteLine($"{n1}{n3}");


// Задание 2
// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.

// Console.Clear();
// Console.Write("Введите 3-х значное число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 100 || n > 999){
//     Console.Write("Вы ошиблись!\nВведите 3-х значное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int n3 = n % 10;
// int n2 = (n / 10) % 10;
// // 547 : 10 = 54
// // n / 10 = 54
// // 54 : 10 = 5/ (ост. 4%)
// int result = 1; // ограничения |2 147 483 647|
// for (int i = 0; i < n3; i++) // n3 раз
//     result *= n2; // result = result * n2

// Console.WriteLine($"{n2}^{n3} = {result}");


// Задание 3
// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// // = - действие присвоение
// // == - проверка на равенство
// if (n % m == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine($"no, {n % m}");



// Задание 4
// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
n = Math.Abs(n);
if (n < 100)
    Console.WriteLine("Третьей цифры нет");
else{
    int x = n % 1000;
    // 45291 : 1000 = 45 (ост. 291)
    Console.WriteLine(x / 100);
}