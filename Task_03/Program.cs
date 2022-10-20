// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] NewArray2(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}
int[] arraynew = NewArray2(12);
Console.WriteLine(PrintArray(arraynew));
string ChetNechet(int[] array)
{
    string result = string.Empty;
    int chet = 0;
    int nechet = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) chet++;
        else nechet++;
    }
    result = "Четных чисел - " + chet + ", а нечетных - " + nechet;
    return result;
}
Console.WriteLine(ChetNechet(arraynew));
