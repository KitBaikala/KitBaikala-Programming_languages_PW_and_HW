// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите данные координат x и y через пробел, x и y не должны быть равны 0: ");
string[] coordinates = Console.ReadLine().Split();
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);

    if (x > 0 && y > 0)
    {
        Console.WriteLine("1 четверть координатной плоскости");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2 четверть координатной плоскости");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3 четверть координатной плоскости");
    }
    else if (x > 0 && y < 0 )
    {
        Console.WriteLine("4 четверть координатной плоскости");
    }
    else if (x == 0 || y == 0)
    {
        Console.WriteLine("Некорректно введены координаты");
    }
        

// He's alive!!!!!!!!