// Задача 3
//Внутри класса Answer напишите метод CheckIfEven, 
//который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

//Пример использования:
//На входе:
//number: '6'
//На выходе:
//четное

//На входе:
//number: '3'
//На выходе:
//нечетное


class Answer {
    static void CheckIfEven(int number)
    {
        if ((number % 2) == 0)
        {
            Console.WriteLine($"четное");
        }
        else
        {
            Console.WriteLine($"нечетное");
        }
    }

    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 6;
        }

        CheckIfEven(number);
    }
}