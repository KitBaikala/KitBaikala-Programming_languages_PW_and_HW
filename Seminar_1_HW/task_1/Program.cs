// ДЗ от первого семинара
//Задача 1.
//Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, 
//какое число большее, а какое меньшее.

//Пример использования:

//На входе:
//firstNumber: '5'
//secondNumber: '6'
//На выходе:
//второе число больше

//На входе:
//firstNumber: '6'
//secondNumber: '3'
//На выходе:
//первое число больше

//На входе:
//firstNumber: '3'
//secondNumber: '3'
//На выходе:
//числа равны


public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber == secondNumber)
        {
            Console.WriteLine($"числа равны");
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"первое число больше`");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"второе число больше");
        }
    }

    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
            firstNumber = 5;
            secondNumber = 5;
        }

        CompareNumbers(firstNumber, secondNumber);
    }
}

