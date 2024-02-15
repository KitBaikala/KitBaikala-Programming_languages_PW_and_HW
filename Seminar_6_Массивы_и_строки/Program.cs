// int i = 1;
// while (i <= 5){
//     Console.WriteLine(i);
//     i++;
// }
/*
i = 1
пока (1 <= 5)
1    i = i + 1 = 1 + 1 = 2
*/
// Задача 3: Напишите программу, которая перевернёт 
// одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

// void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 11); // [1; 10]
// }

// void reverseArray(int[] array){
//     for (int i = 0; i < array.Length / 2; i++){
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// reverseArray(array);
// Console.WriteLine($"Перевернутый массив: [{string.Join(", ", array)}]");

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000); // [100; 999]
// }

// int countAdd(int[] array){
//     int count = 0;
//     foreach (int element in array){
//         if (element % 2 == 0)
//             count++;
//     }
//     return count;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Кол-во четных чисел: {countAdd(array)}");

// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!;
// int result = 0;
// while (number != "q"){
//     result = 0;
//     for (int i = 0; i < number.Length; i++){
//         result += int.Parse(number[i].ToString());
//     }
//     if (result % 2 == 0){
//         number = "q";
//     }
//     else{
//         Console.Write("Введите число: ");
//         number = Console.ReadLine()!;
//     }
// }

// int[] arrayInt = new int[5]; // [0, 0, 0, 0, 0]
// string[] arrayString = new string[5]; // ["", "", "", "", ""]
// char[] arrayChar = new char[5]; // ['', '', '', '', '']



// Задание 1. Задайте массив символов (тип char []). Создайте строку из
// символов этого массива
// Console.Clear();
// Console.Write("Кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// char[] chars = new char[n];
// for (int i = 0; i < chars.Length; i++){
//     Console.Write("Введите элемент массива: ");
//     chars[i] = char.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Начальный массив: [{string.Join(", ", chars)}]");
// Console.WriteLine(string.Join("", chars));
// string result = "";
// foreach (char element in chars){
//     result += element;
// }
// Console.WriteLine(result);


// Задание 2.
//На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Console.Clear();
// Console.Write("Введите строку: ");
// string str = Console.ReadLine()!;
// char[] chars = new char[str.Length];
// for (int i = 0; i < str.Length; i++){
//     chars[i] = str[i];
// }
// Console.WriteLine($"Результат: [{string.Join(", ", chars)}]");


// Задание 3.
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.


bool checkVowel(char ch, char[] vowels){
    foreach (char element in vowels){
        if (element == ch)
            return true;
    }
    return false;
}


Console.Clear();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
char[] vowels = {'a', 'e', 'o', 'i', 'y', 'u'};
int count = 0;
for (int i = 0; i < str.Length; i++){
    if (checkVowel(str[i], vowels))
        count++;
}
Console.WriteLine(count);