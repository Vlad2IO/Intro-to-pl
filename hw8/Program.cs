int programm;
Boolean begin = true;

int[] arrayInt = { };

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("   1.\t Задаст двумерный массив. Упорядочит по возрастанию элементы каждой строки двумерного массива.");
    Console.WriteLine("   2.\t Задаст прямоугольный двумерный массив. Найдёт строку с наименьшей суммой элементов.");
    Console.WriteLine("   3.\t Задаст две матрицы. Будет находить произведение двух матриц.");
    Console.WriteLine("   4.\t Сформирует трёхмерный массив из неповторяющихся двузначных чисел.");
    Console.WriteLine("   \t     Будет построчно выводить массив, добавляя индексы каждого элемента.");
    Console.WriteLine("   5.\t Заполнит спирально массив 4 на 4.");
    Console.WriteLine("------");



    programm = Convert.ToInt32(Console.ReadLine());

    switch (programm)
    {
        case 1:
            CaseProgramm1();
            break;

        case 2:
            CaseProgramm2();
            break;

        case 3:
            CaseProgramm3();
            break;

        case 4:
            CaseProgramm4();
            break;

        case 5:
            CaseProgramm5();
            break;

        default:
            begin = false;
            break;
    }
}

//Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
void CaseProgramm1()
{
    int arrayRows = 3;
    int arrayColumns = 4;
    int arrayMaxValue = 10;
    int arrayMinValue = 1;

    Console.WriteLine("Исходный массив:");
    int[,] array = ArrayGenerator(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

    for (int currentStringIndex = 0; currentStringIndex < arrayRows; currentStringIndex++)
    {
        SortStrOfArray(array, currentStringIndex);
    }

    Console.WriteLine("\nРезультат: ");
    for (int i = 0; i < arrayRows; i++)
    {

        for (int j = 0; j < arrayColumns; j++)
        {
            Console.Write(array[i, j] + "\t|");
        }
        Console.WriteLine("<-- row " + (i + 1));
    }

    WaitingToAnyKey();

    void SortStrOfArray(int[,] array, int currentStringIndex)
    {
        int tempMemory;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = array.GetLength(1) - 1; j > i; j--)
            {
                if (array[currentStringIndex, j] < array[currentStringIndex, j - 1])
                {
                    tempMemory = array[currentStringIndex, j];
                    array[currentStringIndex, j] = array[currentStringIndex, j - 1];
                    array[currentStringIndex, j - 1] = tempMemory;
                }
            }
        }
    }
}

//Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void CaseProgramm2()
{
    int arrayRows = 5;
    int arrayColumns = 4;
    int arrayMaxValue = 10;
    int arrayMinValue = 1;

    Console.WriteLine("Исходный массив:");
    int[,] array = new int[arrayRows, arrayColumns];

    int currentMinStringValue = Int32.MaxValue;
    int currentIndexMinString = -1;

    for (int i = 0; i < arrayRows; i++)
    {
        int sumStringElement = 0;
        for (int j = 0; j < arrayColumns; j++)
        {
            array[i, j] = new Random().Next(arrayMinValue, arrayMaxValue);
            Console.Write(array[i, j] + "\t|");
            sumStringElement += array[i, j];
        }
        Console.WriteLine("<-- row " + (i + 1) + " sum = " + sumStringElement);
        if (sumStringElement < currentMinStringValue)
        {
            currentMinStringValue = sumStringElement;
            currentIndexMinString = i;
        }
    }

    Console.WriteLine("Строка с наименьшей суммой элементов: \nrow " + (currentIndexMinString + 1) + " sum = " + currentMinStringValue);

    WaitingToAnyKey();
}

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void CaseProgramm3()
{
    int arrayRows = 4;
    int arrayColumns = 4;
    int arrayMaxValue = 10;
    int arrayMinValue = 1;

    Console.WriteLine("Исходный массив :");
    int[,] matrixA = ArrayGenerator(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

    Console.WriteLine("\nИсходный массив B:");
    int[,] matrixB = ArrayGenerator(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

    int[,] resultArray = new int[arrayRows, arrayColumns];

    Console.WriteLine("\nРезультат:");
    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            resultArray[i, j] = matrixA[i, j] * matrixB[i, j];
            Console.Write(resultArray[i, j] + "\t|");
        }
        Console.WriteLine("<-- row " + (i + 1));
    }
    WaitingToAnyKey();
}

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void CaseProgramm4()
{
    int arrayMaxValue = 100;
    int arrayMinValue = 10;
    int arraySize = 2;
    int[,,] array = new int[arraySize, arraySize, arraySize];

    int[] donorArray = new int[arraySize * arraySize * arraySize];
    int temp;
    for (int i = 0; i < donorArray.Length; i++) // donor array generation
    {
        while (donorArray[i] == 0)
        {
            temp = new Random().Next(arrayMinValue, arrayMaxValue);
            if (Array.IndexOf(donorArray, temp, i) == -1)
            {
                donorArray[i] = temp;
            }
        }
    }
    // Console.WriteLine($"[{String.Join("; ", donorArray)}]");

    int count = 0;
    for (int arrayDepth1 = 0; arrayDepth1 < arraySize; arrayDepth1++)
    {
        Console.Write(">");
        for (int arrayDepth2 = 0; arrayDepth2 < arraySize; arrayDepth2++)
        {
            Console.Write(">");
            for (int arrayDepth3 = 0; arrayDepth3 < arraySize; arrayDepth3++)
            {
                array[arrayDepth1, arrayDepth2, arrayDepth3] = donorArray[count];
                count++;
                Console.WriteLine($"\t{array[arrayDepth1, arrayDepth2, arrayDepth3]}\t({arrayDepth1},{arrayDepth2},{arrayDepth3})");
            }
        }
    }

    WaitingToAnyKey();
}

//Задача 62. Заполните спирально массив 4 на 4.
void CaseProgramm5()
{
    int arraySize = 4;
    int[,] array = new int[arraySize, arraySize];

    int row = 0;
    int colum = 0;
    int count = 1;
    int maxRow = arraySize - 1;
    int maxColum = arraySize - 1;
    int minRow = 0;
    int minColum = 0;

    array[row, colum] = count;
    count++;
    FillArray(array, row, colum, minRow, maxRow, minColum, maxColum, count);

    void FillArray(int[,] array, int row, int colum, int minRow, int maxRow, int minColum, int maxColum, int count)
    {
        while (colum < maxColum)
        {
            colum++;
            array[row, colum] = count;
            count++;
        }
        minRow++;
        while (row < maxRow)
        {
            row++;
            array[row, colum] = count;
            count++;
        }
        maxColum--;
        while (colum > minColum)
        {
            colum--;
            array[row, colum] = count;
            count++;
        }
        maxRow--;
        while (row > minRow)
        {
            row--;
            array[row, colum] = count;
            count++;
        }
        minColum++;
        if (array[row, colum + 1] == 0) FillArray(array, row, colum, minRow, maxRow, minColum, maxColum, count);
    }

    for (int i = 0; i < arraySize; i++)
    {
        for (int j = 0; j < arraySize; j++)
        {
            Console.Write(array[i, j] + "\t|");
        }
        Console.WriteLine();
    }

}



void WaitingToAnyKey() // пауза до нажатия клавиши
{
    Console.Write(">>> Press any key <<<");
    Console.ReadKey();
    Console.WriteLine();
}

int[,] ArrayGenerator(int lenghtRows, int lenghtColum, int maxValue, int minValue) // рандом генератор
{
    int[,] array = new int[lenghtRows, lenghtColum];
    for (int i = 0; i < lenghtRows; i++)
    {
        for (int j = 0; j < lenghtColum; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
            Console.Write(array[i, j] + "\t|");
        }
        Console.WriteLine("<-- row " + (i + 1));
    }
    return array;
}
