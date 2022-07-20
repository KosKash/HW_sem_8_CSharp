// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой
Console.Clear();
int[,] mass = new int[,]
{
    {9,3,9,9,1},
    {8,4,5,6,7},
    {3,2,1,2,3}
};

void Sum(int[,] array)
{
    int k = 0;
    int[] sum = new int[array.GetLength(0)];
    while (k < sum.Length)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum[k] = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum[k] += array[i, j];
            }
            k++;
        }
    }

    int minValue = sum[0];
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < minValue) minValue = sum[i];
    };
    int index = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (minValue == sum[i]) index = i;
    }
    System.Console.WriteLine(index + 1);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j]);
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("В массиве ");
PrintArray(mass);
System.Console.Write("Строка с минимальной суммой - ");
Sum(mass);