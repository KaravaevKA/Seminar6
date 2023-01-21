// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
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
int[] IntToBin(int num)
{
    int temp = num;
    int count = 0;
    while(Convert.ToBoolean(temp))
    {
        temp /= 2;
        count++;
    }
    int [] array = new int[count];
    for (int i = 0; i<array.Length; i++)
    {
        array[i]=num%2;
        num /= 2;
    }
    Reverse(array);

    return array;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);
int [] array = IntToBin(num);
ShowArray(array);