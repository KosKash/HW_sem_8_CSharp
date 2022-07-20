/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
Console.Clear();
int[,] mass = new int[,]
{
    {1,2,3,4,5},
    {1,8,5,7,4},
    {4,2,9,4,5}
};
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k + 1] > array[i, k])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }

    }
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
System.Console.WriteLine("Исходный массив");
PrintArray(mass);
SortArray(mass);
System.Console.WriteLine("Отсортированный массив");
PrintArray(mass);
