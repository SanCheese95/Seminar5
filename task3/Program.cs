// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double FindDiff(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
            max = randomArray[i];
        if (min > randomArray[i])
            min = randomArray[i];
        i = i + 1;
    }
    return max - min;
}

double[] MakeNewRandomArray(int size, int beginValue, int endValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * (endValue - beginValue) + beginValue;
    }
    return array;
}

double[] array = MakeNewRandomArray(10, 0, 100);
double diff = FindDiff(array);

Console.WriteLine($"[" + string.Join(" / ", array) + "]");
Console.WriteLine($"{diff}");