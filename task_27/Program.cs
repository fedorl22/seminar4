// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число, максимум 2147483647: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = number % 10;
while (number / 10 != 0)
{
    number = number / 10;
    sum = sum + number % 10;
}
Console.WriteLine($"Сумма цифр числа равна {sum}");

bool Validate(int number)
{
    if (number > 1 && number < 2147483647)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int SumDigit(int A)
{
    int sum = A % 10;
    while (A / 10 != 0)
    {
        A = A / 10;
        sum = sum + A % 10;
    }
    return sum;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetNumber("Введите число, максимум 2147483647:  ");
bool isCorrect = Validate(num);
if (isCorrect == true)
{
    int summ = SumDigit(num);
    Console.WriteLine($"Сумма цифр числа  {num} = {summ}");
}
else
{
    Console.WriteLine($"Введено число не из диапазона.");
}

