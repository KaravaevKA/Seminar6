//Прием трех чисел, и вывод, может ли построиться треугольник на их основе
int[] CreateArray()
{
    int[] array = new int[3];
    for (int i = 0; i < 3; i++)
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
void Triangle(int[] array)
{
    if(array[0] < array[1]+array[2] && array[1] < array[0]+array[2] && array[2]<array[0]+array[1])
    Console.WriteLine("Такой треугольник существует");
    else
    Console.WriteLine("Такой треугольник не существует");
}
int[] Array = CreateArray();
Triangle(Array);