// Рекурсия
// Напишите программу, которая складывает 2 числа без прямого сложения.
// +1 -1
// int sumNumber(int a, int b){
//     if (b == 0)
//         return a;
//     // a += 1
//     return sumNumber(a + 1, b - 1);
// }
// // f = sumNumbers
// // f(5, 3) -> f(6, 2) -> f(7, 1) -> f(8, 0) -> 8
// // f(5, 3) <- f(6, 2) <- f(7, 1) <- f(8, 0) <- 8
// // f(5, 3) <- 8 !!! не работает

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{a} + {b} = {sumNumber(a, b)}");


// Задание 1
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// int sumNumber(int n){
//     // n == 0
//     // 123 / 10 = 12    3
//     // 12 / 10 = 1      2
//     // 1 / 10 = 0      1
//     if (n / 10 == 0 || n % 10 == n)
//         return n;
//     return sumNumber(n / 10) + n % 10;
// }
// // f = sumNumber
// /* 
// f(12345) -> f(1234) + 5 = 10 + 5
//             |
//             f(123) + 4 = 6 + 4 = 10
//             |
//             f(12) + 3 = 3 + 3 = 6
//             |
//             f(1) + 2 = 1 + 2 = 3
//             |
//             1
// */

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(sumNumber(n));


// Задание 2
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.


// string printNumbers(int n){
//     if (n == 1)
//         return "1 ";
//     return printNumbers(n - 1) + $"{n} ";
// }
// /* f = printNumbers
// f(5) -> f(4) + "5 " = "1 2 3 4 5 "
//         |
//         f(3) + "4 "
//         |
//         f(2) + "3 "
//         |
//         f(1) + "2 "
//         |
//         "1 "


// /* f = printNumbers
// f(5) -> "5 " + f(4)
//                |
//                "4 " + f(3) = "5 4 " + f(3)
//                       |
//                       "3 " + f(2) = "5 4 3 " + f(2)
//                              |
//                              "2 " + f(1) = "5 4 3 2" + f(1)
//                                     |
//                                     "1 " = "5 4 3 2 1 "
// */

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(printNumbers(n));


// Задание 3
// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.
string printConsonants(string n, int i){
    if (i == n.Length)
        return "";
    else{
        if (n[i] == 'a' || n[i] == 'e' || n[i] == 'y' || n[i] == 'u' || n[i] == 'o' 
        || n[i] == 'i')
            return printConsonants(n, i + 1);
        return n[i] + printConsonants(n, i + 1);
    }
}
/*
n = 10
m = 20
10 + 20 = 30
Console.WriteLine(n + " + " + m + "=" + n + m); 
Console.WriteLine($"{n} + {m} = {n + m}"); // -> "10"
*/


Console.Clear();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
Console.WriteLine(printConsonants(str, 0));