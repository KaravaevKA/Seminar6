//Вывод первых чисел Фибоначчи без рекурсии
int[] Task44()
{
    Console.WriteLine("Введите число N");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    int sum = 0;
    for (int i = 0; i < size; i++)
    {   
        sum = sum +i;
        array[i] = sum;
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("");
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] Array = Task44();
int N = Convert.ToInt32(Console.ReadLine());
ShowArray(Array);
