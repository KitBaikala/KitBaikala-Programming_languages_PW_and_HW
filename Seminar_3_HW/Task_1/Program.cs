// Задача 1. Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

//Начальные условия:

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5

//Console.Clear();
//int[] array = new int[10];
//int count=0;
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 101);
//Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// ????
//int numbers_of_elements(double M[10], double n, int a, int b){
//    int i, k;
//    for (i = 0; i<n; i++)
//    {
//        if (M[i]>a&&M[i] < b)
//           k++;
//    }
//    return k;
//}


//int[] numbers = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
    // 1 вариант
//    int count = 0;
//    foreach (int number in numbers)
//        if (number >= 10 && number <= 90)
//            count++;
// 
//    Console.WriteLine ("Количество элементов массива, значения которых лежат в отрезке от 10 до 90: " + count);
//    // 2 вариант
//    Console.WriteLine ($"Количество элементов массива, значения которых лежат в отрезке от 10 до 90: {numbers.Where (n => (n >= 10 && n <= 90)).Count()}");















//Random rand = new Random (); // объявление экземпляра класса Random
//int[] array = new int[10]; // массив их 10 элементов
//for (int i = 0; i < array. Length; i++)
// {
// array[i] = rand. Next (-10,11); // заполняем массив числами от - 10 до 10
// }
//int counter = 0; // переменная счётчик
//for (int i = 0; i < array. Length; i++)
//{
//if (array[i] = = 7) // если элемент массива равен 7
//{
//counter++; то увеличиваем переменную счётчик на 1
//}
//}
//Console. WriteLine ("Кол-во элементов равных 7: " + counter);
//Console. ReadLine (); // чтение с консоли, иначе закроется


public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
         //Введите сюда свое решение
      int count = 0;
      foreach(int element in numbers){
        if (element >= minRange && element <= maxRange)
          count++;
      }
      return count;
    }
    
    public static void PrintResult(int[] array)
    {
        Console.WriteLine(CountItemsRange(array, 10, 90));
          //Введите сюда свое решение
    }


    public static void PrintResult(int[] array)
    {
            int count = 0;
      foreach(int element in array){
        if (element >= 10 && element <= 90)
          count++;
      }
        Console.WriteLine(CountItemsRange(count);
          //Введите сюда свое решение
    }