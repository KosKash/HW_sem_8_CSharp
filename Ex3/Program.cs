// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
int[,] matrix1 = new int[,]
{
    {3,5},
    {2,1}
};

int[,] matrix2 = new int[,]
{
    {8,2},
    {1,7}
};

int[,] matrixAns = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

for (int i = 0; i < matrixAns.GetLength(0); i++)
    for (int j = 0; j < matrixAns.GetLength(0); j++)
        for (int k = 0; k < matrixAns.GetLength(1); k++)
            matrixAns[i, k] += matrix1[i, j] * matrix2[j, k];


void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

Print(matrixAns);