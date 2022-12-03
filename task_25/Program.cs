// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

Console.WriteLine("Введите положительное число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительную степень: ");
int B = Convert.ToInt32(Console.ReadLine());
int mult = 1;
for (int i = 1; i <= B; i++)
{
mult = mult *A;
}
Console.WriteLine($"Число {A} в степени {B} равно {mult}");

bool Validate(int number1,int number2)
{
    if (number1 > 0 && number2 > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int ADegreeB(int A, int B)
{
    int mult = 1;
    for (int i =1; i<=B; i++)
    {
        mult =mult *A;  
    }
    return mult;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()); 
}

int number1 = GetNumber("Введите положительное число: ");
int number2 = GetNumber("Введите положительную степень: ");
bool isCorrect = Validate(number1, number2);
if (isCorrect==true)
{
    int mul =ADegreeB(number1, number2);
    Console.WriteLine($"Число {number1} в степени {number2} = {mul}");
}
else
{
Console.WriteLine($"Невозможно возвести в степень.");
}
