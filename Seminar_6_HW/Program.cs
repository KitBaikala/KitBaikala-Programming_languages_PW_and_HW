// / 6 - ой семинар:
// Задача 1: Создание строки из двумерного массива символов
// public class Task1
// {
//     public static void Main(string[] args)
//     {
//         // Инициализация двумерного массива символов
//         char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } }; // здесь можно еще так - { { 'a', 'b', 'c', 'd' }, { 'e', 'f', 'g', 'h'  } };
//         // Вызов метода для создания строки из 2D массива
//         string result = CreateStringFrom2DArray(charArray);
//         // Вывод результата
//         Console.WriteLine(result);
//     }
//     // Метод для создания строки из двумерного массива символов
//     public static string CreateStringFrom2DArray(char[,] array)
//     {
//         string result = "";
//         // Цикл по каждому элементу в двумерном массиве
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 // Добавление каждого символа в результирующую строку
//                 result += array[i, j];
//             }
//         }
//         return result;
//     }
// }
// / Это решение из бразца

// / ниже мое решение

// Console.Clear();
// char[,] array = new char[,]
// {
//     {'a', 'b', 'c'},
//     {'d', 'e', 'f'},
//     {'g', 'h', 'i'}
// };
// string result = string.Empty;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         result += array[i, j];
//     }
// }
// Console.WriteLine(result);

// / Задача 2: Замена заглавных букв на строчные в строке - решение из образца
// public class Task2
// {
// public static void Main(string[] args)
// {
// // Входная строка со смешанными буквами обоих регистров
// string input = "aBcD1ef!-";
// // Преобразование всех заглавных букв в строчные
// string result = input.ToLower();
// // Вывод результата
// Console.WriteLine(result);
// }
// }

// мой вариант
// string input = "hBHVYVIkjbkjiugOUGGGJPihiICHpPISISIIShcihisisPIHPISJJSWJWBhdhduehjUuHtGRgyuijyTfioOIYggTTf";
// string result = input.ToLower();
// Console.WriteLine(result);


// // 3 task  Задайте произвольную строку. Выясните, является ли она палиндромом.
// public class Task3
// {
// public static void Main(string[] args)
// {
// // Входная строка для проверки
// string input = "шалаш";
// // Вызов метода для проверки, является ли строка палиндромом
// bool isPalindrome = IsPalindrome(input);
// // Вывод результата
// Console.WriteLine(isPalindrome ? "Да" : "Нет");
// }
// // Метод для проверки, является ли строка палиндромомpublic static bool IsPalindrome(string str)
// {
// // Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
// string normalized = new
// string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// // Сравнение строки с ее перевернутым вариантом
// return normalized.SequenceEqual(normalized.Reverse());
// }
// }



// Console.Clear();
// Console.WriteLine("Введите слово");
// string reverse = string.Empty;
// string text = Console.ReadLine();
// for (int i = text.Length - 1; i >= 0; i--)
// {
//     reverse += text[i];
// }
//     if (text == reverse)
// {
//     Console.WriteLine("Является полиндромом");
// }
//     else
// {
//     Console.WriteLine("НЕ является полиндромом");
// }


// Задача 4 (необязательная): Обратный порядок слов в строкеpublic class Task4
// {
// public static void Main(string[] args)
// {
// // Входная строка со словами, разделенными пробелами
// string input = "Hello my world";
// // Вызов метода для обращения порядка слов в строке
// string result = ReverseWords(input);
// // Вывод результата
// Console.WriteLine(result);
// }
// // Метод для обращения порядка слов в строке
// public static string ReverseWords(string str)
// {
// // Разделение строки на слова
// string[] words = str.Split(' ');
// // Обращение порядка слов
// Array.Reverse(words);
// // Соединение слов обратно в строку с пробелами
// return string.Join(" ", words);
// }
// }


// Проверка от преподавателя
// // Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
// Console.Clear();
// char[,] chars = {{'h', 'e', 'l'}, {'l', 'o', ' '}, {'w', 'o', 'r'}};
// string resultStr = String.Empty; // "" - String.Empty
// for (int i = 0; i < chars.GetLength(0); i++){
//     for (int j = 0; j < chars.GetLength(1); j++){
//         resultStr += chars[i, j];
//     }
// }
// Console.WriteLine(resultStr);

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// Console.Clear();
// Console.Write("Введите строку: ");
// string str = Console.ReadLine()!;
// string resultStr = String.Empty;
// foreach (char element in str){
//     if (Char.IsUpper(element)){
//         resultStr += Char.ToLower(element);
//     }
//     else{
//         resultStr += element;
//     }
// }
// Console.WriteLine(resultStr);


// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// Console.Clear();
// Console.Write("Введите строку: ");
// string str = Console.ReadLine()!;
// int count = 0;
// for (int i = 0; i < str.Length / 2; i++){
//     if (str[i] == str[str.Length - 1 - i])
//         count++;
// }
// if (count == str.Length / 2)
//     Console.WriteLine("YES");
// else
//     Console.WriteLine("NO");



//Задача 4*(не обязательная): Задайте строку, состоящую из слов, 
// разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
// Console.Clear();
// Console.Write("Введите строку: ");
// string[] str = Console.ReadLine()!.Split();
// string resultStr = String.Empty;
// for (int i = str.Length - 1; i >= 0; i--){
//     resultStr += str[i] + " ";
// }
// Console.WriteLine(resultStr);