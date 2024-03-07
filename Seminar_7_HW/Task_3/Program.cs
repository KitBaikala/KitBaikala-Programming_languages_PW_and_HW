// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.


Console.Clear();
Console.Write("Ввидите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int i = 0;
int[] array = new int[n];
FillingArray(array, i);
Console.WriteLine("Исходный массив: ");
Console.WriteLine(PrintStartArray(array, i));
Console.WriteLine("Результат: ");
Console.WriteLine(PrintEndArray(array, i));

int[] FillingArray(int[] array, int i)
{
    if (i < array.Length)
    {
        array[i] = new Random().Next(1, 100);
        FillingArray(array, i + 1);
    }
    return array;
}

string PrintStartArray(int[] array, int i)
{
    if (i == array.Length - 1)
    {
        return $"{array[array.Length - 1]} ";
    }
    return PrintStartArray(array, i + 1) + $"{array[i]} ";
}

string PrintEndArray(int[] array, int i)
{
    if (i == array.Length - 1)
    {
        return $"{array[array.Length - 1]} ";
    }
    return $"{array[i]} " + PrintEndArray(array, i + 1);
}