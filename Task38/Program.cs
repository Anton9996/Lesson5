// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.WriteLine("Введите число элементов массива");
int qty = Convert.ToInt32(Console.ReadLine());
if (qty <= 0)
{
    Console.WriteLine("Число элементов массива, должно быть натуральным числом");
    return;
}
double[] arr = CreateArrayRndDouble(qty, 0, 9);
PrintArray(arr);
double finResult = Difference(arr);
Console.Write($"-> {finResult}");

//methods

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double Difference(double[] array)
{
    double result = 0;
    double max = double.MinValue;
    double min = double.MaxValue;
    //double maxValue = i.Max();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            // найден больший элемент
            min = array[i];
        }
                if (array[i] > max)
        {
            // найден больший элемент
            max = array[i];
        }
    }
    result = max - min;
    return Math.Round(result, 2);
}


