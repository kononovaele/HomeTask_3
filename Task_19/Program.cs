// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

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
