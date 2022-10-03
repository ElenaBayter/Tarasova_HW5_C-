// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetArray(8, 1, 9);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2==0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine($"Sum of numbers from uneven positions is {sum}");
