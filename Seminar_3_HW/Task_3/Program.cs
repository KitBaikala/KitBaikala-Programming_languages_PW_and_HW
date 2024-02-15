//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.

//Начальные условия:

//int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
//Выводится: 5.15

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
Random rand = new Random();
for (int i = 0; i < a; i++)
{
randomArray[i] = rand.NextDouble();
Console.Write(($"{randomArray[i]:F2} "));
}

}

double raz(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

mas(a);
Console.Write({raz(randomArray):F2});


public static double FindMin(double[] numbers)
    {
        //Напишите свое решение здесь
      double minNumber = numbers[0];
      for (int i = 1; i < numbers.Length; i++){
        if (minNumber > numbers[i]){
          minNumber = numbers[i];
        }
      }
      return minNumber;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
               //Напишите свое решение здесь
      double maxNumber = numbers[0];
      for (int i = 1; i < numbers.Length; i++){
        if (maxNumber < numbers[i]){
          maxNumber = numbers[i];
        }
      }
      return maxNumber;
    }
    
    
    
    public static void PrintResult(double[] array)
    {
        //Напишите свое решение здесь
      Console.WriteLine(FindMax(array) - FindMin(array));
    }