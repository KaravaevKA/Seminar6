int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void CountPositive(int[] array)
{
    int count = 0;
    foreach (var i in array)
    {
        if (i > 0) count ++;
    
    }
    Console.WriteLine($"Пользователь ввел {count} положительных элементов");
}

int[] Array = CreateArray();
ShowArray(Array);
CountPositive(Array);