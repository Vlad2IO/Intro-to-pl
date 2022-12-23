int programm, result, enterNumber;
Boolean begin = true;

while (begin)
{
	Console.WriteLine("------");
	Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
	Console.WriteLine("1. Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
	Console.WriteLine("2. Принимает на вход число и выдаёт сумму цифр в числе.");
	Console.WriteLine("3. Задаёт массив из X элементов и выводит их на экран.");
	Console.WriteLine("------");


	programm = Convert.ToInt32(Console.ReadLine());

	switch (programm)
	{
		case 1:
			// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

			int enterNumberA, enterNumberB;

			Console.WriteLine("Для формулы A^B");
			Console.Write("Введите число A: ");
			enterNumberA = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите число B: ");
			enterNumberB = Convert.ToInt32(Console.ReadLine());

			result = enterNumberA;

			for (int i = 2; i <= enterNumberB; i++)
			{
				result *= enterNumberA;
			}

			Console.WriteLine($"{enterNumberA}^{enterNumberB} = {result}");
			break;

		case 2:
			//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

			Console.Write("Введите любое число: ");
			enterNumber = Convert.ToInt32(Console.ReadLine());
			result = 0;
			while (enterNumber != 0)
			{
				result += enterNumber % 10;
				enterNumber /= 10;
			}

			Console.WriteLine($"Сумма цифр в числе = {result}");

			break;

		case 3:
			//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
			Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
			Console.Write("Введите любое число (A): ");
			enterNumber = Convert.ToInt32(Console.ReadLine());

			int[] array = new int[enterNumber];

			for (int i = 0; i < enterNumber; i++)
			{
				array[i] = new Random().Next(enterNumber + 1);
				Console.Write(array[i] + "; ");
			}
			Console.WriteLine();

			//Вариант вывода вне цикла:
			//Console.WriteLine($"[{String.Join("; ", array)}]");

			break;

		default:
			begin = false;
			break;
	}
}
