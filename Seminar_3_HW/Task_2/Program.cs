// Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

// Начальные условия:

// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива

// Выводится: 6


int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
void  PrintResult = 0;
int count = 0;
    for (int i = 0; i < 10; i++)
    {
         if ((array[i] % 2) == 0)
        count++;
    }
PrintResult(count);
            

            public static int CountEvenItems(int[] numbers)
    {
      return 0;
        //Напишите свое решение здесь
    }
    
    public static void PrintResult(int[] array)
    {
        //Напишите свое решение здесь
      int count = 0;
      foreach(int element in array){
        if (element % 2 == 0)
           count++;
      }
      Console.WriteLine(count);
    }