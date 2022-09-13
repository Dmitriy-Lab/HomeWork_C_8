// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
Console.WriteLine();
Console.WriteLine("Внимание! Сумма строк, столбцов и величины по оси z должна быть меньше или равна 13!");
Console.WriteLine();
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность массива по оси z: ");
int zElements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (rows + columns + zElements > 13)        // Проверка условия достаточности двузначных чисел
{
    Console.WriteLine("НЕДОСТАТОЧНО УНИКАЛЬНЫХ ДВУЗНАЧНЫХ ЭЛЕМЕНТОВ ДЛЯ ОТОБРАЖЕНИЯ МАССИВА");
}
else
{
    // Задаем вспомогательный массив из двузначных элементов по порядку
    // и затем тасуем элементы внутри него

    int count = 0;
    int[] arrayRandom = new int[89];
    for (int i = 0; i < arrayRandom.Length; i++)
    {
        arrayRandom[i] = 10 + i;
    }
    for (int i = 0; i < arrayRandom.Length; i++)
    {
        int j = new Random().Next(arrayRandom.Length);
        int temp = arrayRandom[j];
        arrayRandom[j] = arrayRandom[i];
        arrayRandom[i] = temp;
    }

    // Задаем трехмерный массив и заполняем его элементами из 
    // вспомогательного массива arrayRandom по порядку

    int[,,] array = new int[rows, columns, zElements];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = arrayRandom[count];
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");     // Выводим согласно заданию
                count += 1;
            }
            Console.WriteLine();
        }
    }
}
// Кто сказал, что наши домашки недостаточно сложные???
