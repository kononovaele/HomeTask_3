//
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//

// Функция возвращает true если digit - палиндром, если нет - то возвращает - false
// Функцию можно расширить, если добавить delimiterHigh и n как параметры,
// тогда задавая разлдичные значения delimiterHigh и n, можно проверять на палидром числа большей разрядности.
// Например: delimiterHigh = 1000000 и n = 3, проверка семизначного числа
// delimiterHigh = 100000000 и n = 4, проверка девятизначного числа
bool IsDigitPalindrom(int value)
{
    int delimiterHigh = 10000;
    int delimiterLow = 10;
    int n = 2;
    bool isPalindrom = false;

    for (int i = 0; i < n; ++i)
    {
        if ((value / delimiterHigh) == (value % delimiterLow))
        {
            isPalindrom = true;
        }
        else
        {
            isPalindrom = false;
            break;
        }
        value = value % delimiterHigh;
        value = value / delimiterLow;
        delimiterHigh = delimiterHigh / 100;
    }

    return isPalindrom;
}

// Функция печатает число палиндром которого мы ищем и результат
void Print(int digit, bool isPalindrom)
{

    Console.Write(" Our digit: ");
    Console.Write(digit);
    Console.Write(",  result: ");
    Console.WriteLine(isPalindrom);

}

void main()
{
    Console.WriteLine(" ------- Task-19 -------");

    int n = 14212;
    Print(n, IsDigitPalindrom(n));
    n = 12821;
    Print(n, IsDigitPalindrom(n));
     n = 23432;
    Print(n, IsDigitPalindrom(n));

}

main();
