// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите число элементов массива");
int qty = Convert.ToInt32(Console.ReadLine());
if (qty <= 0)
{
    Console.WriteLine("Число элементов массива, должно быть натуральным числом");
    return;
}
int[] arr = CreateArrayRndInt(qty, 0, 9);
PrintArray(arr);
int[] mulrsArr = GetMults(arr);
Console.Write($"-> ");
PrintArray(mulrsArr);
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

int[] GetMults(int[] array)
{
    int size = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
    int[] result = new int[size];

    int firstIndex = 0;
    int lastIndex = array.Length - 1;
    int i = 0;
    while (lastIndex > firstIndex)
    {
        result[i] = array[firstIndex]*array[lastIndex];
        ++firstIndex;
        --lastIndex;
        ++i;
    }
    if (lastIndex == firstIndex)
    {
        result[size-1]= array[lastIndex];
    }
    return result;
}