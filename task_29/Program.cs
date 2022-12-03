//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран. Данные вводятся с консоли пользователем

int[] array1 = new int[8];
for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива: ");
    int num = Convert.ToInt32(Console.ReadLine());
    array1[i] = num;
}
Console.WriteLine(string.Join(", ", array1));

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] array2 = new int[8];
for (int i = 0; i < array2.Length; i++)
{
    array2[i] = GetNumber($"Введите {i} элемент массива: ");
}
Console.WriteLine($"[{string.Join(", ", array2)}]");

