// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int [,] matrix = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
Console.WriteLine("Задан массив");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
        Console.WriteLine();
}
Console.WriteLine();

void MedianSumOfColums(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summaMedianSumOfColums = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           summaMedianSumOfColums += matrix[i, j];
        }
double resultMathRound = Math.Round(summaMedianSumOfColums / matrix.GetLength(0), 2);
Console.WriteLine($"Среднее арифметическое столбца {j} = {resultMathRound} ");
    }
}
MedianSumOfColums(matrix);
