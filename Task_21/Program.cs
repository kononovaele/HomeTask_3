//
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
//  между ними в 3D пространстве
//
using System;

// Функция принимает три аргумента (целые числа) и возвращает расстояние между ними (вещественное число)
double GetDistance(int x, int y, int z)
{

    return Math.Sqrt(x * x + y * y + z * z);

}

void main()
{
    Console.WriteLine(" ------- Task-21 -------");

    int x = 1;
    int y = 1;
    int z = 1;
    //Сonsole.WriteLine(GetDistance(x, y, z));
    //Сonsole.Write(12);

    x = 2; y = 2; z = 2;
    //Сonsole.WriteLine(GetDistance(x, y, z));

    x = 10;
    y = 10;
    z = 10;
    //Сonsole.WriteLine(GetDistance(x, y, z));

}

main();

