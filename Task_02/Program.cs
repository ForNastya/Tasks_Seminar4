// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] fillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

int[] ourArray = fillArray(12, 0, 9);
int negativeSum = 0;
int positiveSum = 0;
foreach (int el in ourArray)
{
    if (el > 0)
    {
        positiveSum += el;
    }
    else
    {
        negativeSum += el;
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных элементов массива: {negativeSum}, сумма положительных элементов массива {positiveSum} ");