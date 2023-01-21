int[] RandomArray(int N)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(10, 99 +1);
    }
    return RandomArray;
}
int[] Array = RandomArray(7);

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] Reverse(int[] array)
{
    int temp = 0;
    for (int i = 0; i<array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[(array.Length - 1) -i];
        array[(array.Length - 1) - i] = temp;
    }
    return array;
}
Console.Write("Массив:   ");
ShowArray(Array);

Console.WriteLine("Перевернутый массив: ");
Reverse(Array);
ShowArray(Array);
