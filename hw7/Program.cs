int programm;
Boolean begin = true;

int[] arrayInt = { };

while (begin)
{
	Console.WriteLine("------");
	Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
	Console.WriteLine("   1.\t Создаст двумерный массив размером mXn, заполненный случайными вещественными числами.");
	Console.WriteLine("   2.\t Поиск позиции числа в сгенерированном массиве.");
	Console.WriteLine("   22.\t Помск числа по позиции в сгенерированном массиве.");
	Console.WriteLine("   3.\t Создаст двумерный массив из целых чисел. ");
	Console.WriteLine("   \t     Найдёт среднее арифметическое элементов в каждом столбце.");


	programm = Convert.ToInt32(Console.ReadLine());

	switch (programm)
	{
		case 1:
			CaseProgramm1();
			break;
		case 2:
			CaseProgramm2();
			break;
		case 22:
			CaseProgramm22();
			break;
		case 3:
			CaseProgramm3();
			break;
		default:
			begin = false;
			break;
	}
}

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void CaseProgramm1()
{
	int arrayRows = 3;
	int arrayColumns = 4;
	int arrayMaxValue = 100;
	int arrayMinValue = 1;
	double[,] array = new double[arrayRows, arrayColumns];

	for (int i = 0; i < arrayRows; i++)
	{
		for (int j = 0; j < arrayColumns; j++)
		{
			array[i, j] = new Random().NextDouble();
			array[i, j] = array[i, j] * (arrayMaxValue - arrayMinValue) + arrayMinValue;
			array[i, j] = Math.Round(array[i, j], 2);
			Console.Write(array[i, j] + "\t|");
		}
		Console.WriteLine("<-- row " + (i + 1));
	}
	WaitingToAnyKey();
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// поиск позиции числа
void CaseProgramm2()
{
	int arrayRows = 3;
	int arrayColumns = 4;
	int arrayMaxValue = 10;
	int arrayMinValue = 1;
	int[,] array = ArrayGenerator(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

	// int findNumber = new Random().Next(arrayMinValue, arrayMaxValue * 2);
	// Console.WriteLine("ищем число --> " + findNumber);

	Console.Write("введите искомое число --> ");
	int findNumber = Convert.ToInt32(Console.ReadLine());
	bool numberFound = false;

	for (int i = 0; i < arrayRows; i++)
	{
		for (int j = 0; j < arrayColumns; j++)
		{
			if (array[i, j] == findNumber)
			{
				Console.WriteLine($"Число найено: Строка {i + 1} ; Колонка {j + 1}");
				numberFound = true;
			}
		}
	}

	if (numberFound != true) Console.WriteLine("Число НЕ найдено");
	WaitingToAnyKey();
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// помск числа по позиции
void CaseProgramm22()
{
	int arrayRows = 3;
	int arrayColumns = 4;
	int arrayMaxValue = 10;
	int arrayMinValue = 1;
	int[,] array = ArrayGenerator(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

	// int findNumber = new Random().Next(arrayMinValue, arrayMaxValue * 2);
	// Console.WriteLine("ищем число --> " + findNumber);
	Console.WriteLine("введите позицию");
	Console.Write("Строка: ");
	int coordinateRow = Convert.ToInt32(Console.ReadLine());
	Console.Write("Столбец: ");
	int coordinateColumn = Convert.ToInt32(Console.ReadLine());

	if (coordinateRow <= arrayRows && coordinateColumn <= arrayColumns)
	{
		Console.WriteLine($"Это число: " + array[coordinateRow - 1, coordinateColumn - 1]);
	}
	else Console.WriteLine("Число НЕ найдено");
	WaitingToAnyKey();
}


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void CaseProgramm3()
{
	int arrayRows = 3;
	int arrayColumns = 4;
	int arrayMaxValue = 10;
	int arrayMinValue = 1;

	int[,] array = ArrayGenerator(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

	Console.WriteLine("Среднее арифметическое столбцов:");

	double arithmeticalMean = 0;

	for (int j = 0; j < arrayColumns; j++)
	{
		for (int i = 0; i < arrayRows; i++)
		{
			arithmeticalMean += array[i, j];
		}
		arithmeticalMean = Math.Round(arithmeticalMean / arrayRows, 3);
		Console.Write(arithmeticalMean + "\t|");
		arithmeticalMean = 0;
	}
	Console.WriteLine();
	WaitingToAnyKey();
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
