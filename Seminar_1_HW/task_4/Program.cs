//Задача 4 
//Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход 
//принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), 
//после каждого числа должен быть знак пробела.

//На входе:
//number = 5 
//На выходе:
//2 4 

//На входе:
//number = 8 
//На выходе:
//2 4 6 8 

public class Answer {
    static void PrintEvenNumbers(int number)
    {
        for (int count = 2; count <= number; count += 2)
        {
            Console.Write($"{count} ");
        }
    }

    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 6;
        }

        PrintEvenNumbers(number);
    }
}