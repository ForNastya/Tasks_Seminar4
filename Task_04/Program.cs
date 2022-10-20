// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int[123];
int count = 0;
for (int 1 = 0; int < array.Length; int++)
{
    array [i] = new Random().Next(0, 1000);
    Console.WriteLine(array[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
    if(array[j] > 9 & array[j] < 100) count = count + 1;
}
Console.WriteLine();
Console.WriteLine("Массив содержит следующее количество элементов из отрезка 10, 99] - ");
Console.WriteLine(count);

