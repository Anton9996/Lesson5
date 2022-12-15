// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите число элементов массива");
int qty = Convert.ToInt32(Console.ReadLine());
if (qty <= 0)
{
    Console.WriteLine("Число элементов массива, должно быть натуральным числом");
    return;
}
int[] arr = CreateArrayRndInt(qty, 0, 9);
PrintArray(arr);
int finResult = SumOfOddIndexes(arr);
Console.Write($"-> {finResult}");
//methods
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int SumOfOddIndexes(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}