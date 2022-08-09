int[] array = getArray(10, 0, 20);

int[] getArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", result), "]");
    return result;
}

int Diff(int[] arr)
{
    int min = arr[0];
    int max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }

    int result = max - min;

    return result;
}

Console.WriteLine($"Разница между минимальным и максимальным элементом массива: { Diff(array) }");