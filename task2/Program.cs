// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int FindSum(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}

int[] MakeNewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
    }
    return array;
}

int[] array = MakeNewRandomArray(10, 0, 100);
int sum = FindSum(array);
Console.WriteLine($"[" + string.Join(",", array) + "]");
Console.WriteLine($"{sum}");