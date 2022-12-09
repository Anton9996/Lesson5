// проверка на везучесть , вероятность выйгрыша целых 0.5%
Console.WriteLine("Проверь на сколько ты везунчик!");
Console.WriteLine("Напиши число от -100 до 100");
Console.WriteLine("Программа сгенерирует масив из 8 элементов, рандомно заполненых числами от -100 до 100");
Console.WriteLine("И если в нем будет твое число, можешь считать себя счастливчиком");
int luckyNumber = Convert.ToInt32(Console.ReadLine());

Console.Write($"{luckyNumber}; массив ");
int[] arr = CreateArrayRndInt(8, -101, 101);
PrintArray(arr);
string result = CheckingArray(arr, luckyNumber) ? "Да,это число есть можешь считать себя счастливчикос" : "Нет, попробуй еще раз, когда-нибудь получится";
Console.Write($"-> {result}");

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

bool CheckingArray(int[] array, int luckyNumber)
{
    if (array == null || array.Length <= 0)
    {
        return false;
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == luckyNumber)
            return true;
    }
    return false;
}