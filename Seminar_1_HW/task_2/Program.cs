// Задача 2
// Внутри класса Answer напишите метод FindMax, который принимает 
//на вход три числа и выдаёт максимальное из этих чисел.

public class Answer {
    static int FindMax(int a, int b, int c)
    {
      int max = a;
        if (max < b)
        {
            max = b;
        }
        if (max < c)
        {
            max = c;
        }
        return max;
    }

    static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);
        } else {
            a = 5;
            b = 6;
            c = 7;
        }

        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}