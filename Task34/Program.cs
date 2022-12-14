// Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая 
//  покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Данная програма покажет сколько четный чисел в масиве!");

int[] arr = CreateArrayRndInt(5, -4, 10); // задай длину и диапозон чисел масива
PrintArray(arr);

int cnt = CountingEvenNumbers(arr);
Console.WriteLine($"-> {cnt}");

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
    Console.WriteLine("]");
}

int CountingEvenNumbers(int[] array)
{
    if (array == null || array.Length <= 0)
    {
        return 0;
    }

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
            ++count;
    }
    return count;
}