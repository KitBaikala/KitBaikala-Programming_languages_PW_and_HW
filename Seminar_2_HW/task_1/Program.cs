// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.Write("Введите число для проверки кратности:  ");
int number = int.Parse(Console.ReadLine());

    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Число кратно и 7 и 23");
    }
    else if (number % 7 == 0)
    {
        Console.WriteLine("Число кратно только 7");
    }
    else if (number % 23 == 0)
    {
        Console.WriteLine("Число кратно только 23");
    }
    else 
    {
        Console.WriteLine("Число НЕ кратно ни 7, ни 23.");
    }
   

   // работает слава богу
   