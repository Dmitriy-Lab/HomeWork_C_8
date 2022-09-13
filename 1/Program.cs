// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-50, 51);
        Console.Write(matrix[i, j] + "\t");         // Выводим массив для проверки
    }
    Console.WriteLine();
}
Console.WriteLine(" ");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)   // Добавляем цикл сравнения элементов
        {
            if (matrix[i, k] < matrix[i, k + 1])
            {
                int count = matrix[i, k];
                matrix[i, k] = matrix[i, k + 1];
                matrix[i, k + 1] = count;
            }
        }
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}