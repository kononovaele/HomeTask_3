//
// Задача 23. Напишите программу, которая принимает на вход числа (N) и выдает таблицу кубов от 1 до N
//

// Вывод в строку число и значения его кубов от 1 до значения числа n
void PrintStrOfTable(int n)
{
    int value;

    Console.WriteLine("");
    Console.Write(n);
    Console.Write(" -> ");

    for(int i = 1; i <= n; ++i)
    {
        value = i * i * i;
        Console.Write(value);
        if(i != n)
        {
            Console.Write(", ");
        }
    }

}

void main()
{
    Console.WriteLine("\n ------- Task-23 -------");

    PrintStrOfTable(3);
    PrintStrOfTable(5);

}

main();

