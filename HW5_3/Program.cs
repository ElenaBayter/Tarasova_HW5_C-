// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = GetArray(10, 10, 99);
Console.WriteLine(String.Join(" ", array));


double[] GetArray(int size, double minValue, double maxValue)
{
    double [] array = new double[10];
    for (int i = 0; i < size; i++)
    {
        double x = new Random().NextDouble();
        array[i] = Math.Round(x * (99-10) + 10, 2);
    }
    return array;
}

double maxElement = array[0];
for (int index = 0; index < array.Length; index++)
{
    if (array[index] > maxElement)
        maxElement = array[index];
}
Console.WriteLine($"Max element is {maxElement}");

double minElement = array[0];
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < minElement)
        minElement = array[index];
}
Console.WriteLine($"Min element is {minElement}");

double dif = Math.Round((maxElement - minElement), 2);
Console.WriteLine($"Difference of Max and Min elements of array is {dif}");