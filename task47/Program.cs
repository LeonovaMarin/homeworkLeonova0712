// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите число строк M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов N");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrayTable = new int[m, n];
Console.WriteLine();
var random = new Random(); //не могу понять, как задать вещественные числа double (double random = new Random(); не принимает)


Console.WriteLine($"Двумерный массив размером {m}*{n}, заполненный случайными вещественными числами: ");
for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        arrayTable[i,j] = random.Next(-10, 10); // должно быть так? но не работае arrayTable[i,j] = random.NextDouble(-10, 10);
        Console.Write($"{arrayTable[i,j]} ");
    }
    Console.WriteLine();
}
