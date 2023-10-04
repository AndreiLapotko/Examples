//Упорядочить массив

int[] FillRndArray(int length, int min, int max) // заполняем массив случайными целыми числами от min до max
{
    int[] arr = new int[length];
    Random rnd = new();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(i != arr.Length-1 ? $"{arr[i]}, " : $"{arr[i]}");
    }
    Console.WriteLine();
}

int[] SortingArrayMinToMax(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }
        int temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;
    }

    return arr;
}

int[] SortingArrayMaxToMin(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition]) maxPosition = j;
        }
        int temp = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temp;
    }

    return arr;
}

int[] array = FillRndArray(10, 1, 20);
PrintArray(array);
int[] sortedArr = SortingArrayMinToMax(array);
PrintArray(sortedArr);
sortedArr = SortingArrayMaxToMin(array);
PrintArray(sortedArr);