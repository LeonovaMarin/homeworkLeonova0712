// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] matrix = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
        Console.WriteLine();
}

Console.WriteLine("Введите номер строки элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

    if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
        Console.WriteLine($"Такой элемент есть, это {matrix[row, column]}");
    else
        Console.WriteLine($"Строка: {row}, колонка {column} Такой элементв массиве отсутствует");
