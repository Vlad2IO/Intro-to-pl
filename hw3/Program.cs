int programm, firstNum, endNum, count, num, resultInt;
double resultDoub;
string numStr;
Boolean begin = true;
Boolean error;

while (begin)
{
	Console.WriteLine("------");
	Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
	Console.WriteLine("1. Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
	Console.WriteLine("2. Принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
	Console.WriteLine("3. Принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
	Console.WriteLine("------");

	programm = Convert.ToInt32(Console.ReadLine());

	switch (programm)
	{
		case 1:
			// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
			Console.Write("Введите пятизначное число: ");
			numStr = Console.ReadLine();
			firstNum = 0;
			endNum = numStr.Length - 1;

			if (endNum == 4)
			{
				while (firstNum < endNum && Char.IsDigit(numStr[firstNum]) && Char.IsDigit(numStr[endNum]))
				{
					if (numStr[firstNum] == numStr[endNum])
					{
						firstNum++;
						endNum = endNum - 1;
					}
					else
					{
						Console.WriteLine($"{numStr[firstNum]} != {numStr[endNum]} : число {numStr} не палиндром");
						firstNum = 5;
					}
				}
				if (firstNum == 2) Console.WriteLine($"число {numStr} - палиндром");
				if (firstNum != 2 && firstNum != 5) Console.WriteLine($"{numStr} - не верный ввод");
			}
			else Console.WriteLine("Значение не пятизначное");

			break;

		case 2:
			//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
			int aX, aY, aZ;
			int bX, bY, bZ;
			Console.WriteLine("Введите посследовательность координат: ");
			Console.Write("aX: ");
			aX = Convert.ToInt32(Console.ReadLine());
			Console.Write("aY: ");
			aY = Convert.ToInt32(Console.ReadLine());
			Console.Write("aZ: ");
			aZ = Convert.ToInt32(Console.ReadLine());

			Console.Write("bX: ");
			bX = Convert.ToInt32(Console.ReadLine());
			Console.Write("bY: ");
			bY = Convert.ToInt32(Console.ReadLine());
			Console.Write("bZ: ");
			bZ = Convert.ToInt32(Console.ReadLine());

			resultDoub = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2);
			resultDoub = Math.Sqrt(resultDoub);
			resultDoub = Math.Round(resultDoub, 2);
			Console.WriteLine(resultDoub);
			break;


		case 3:
			//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
			Console.Write("Введите любое число: ");
			num = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= num; i++) Console.Write($"{Math.Pow(i, 3)}, ");
			Console.WriteLine(" ");
			break;

		default:
			begin = false;
			break;
	}
}

void strIsNum(string Str)
{
	int Num;
	bool isNum = int.TryParse(Str, out Num);

	if (isNum)
	{
		Console.WriteLine("Это число");
	}
	else
	{
		Console.WriteLine("Это НЕ число");
	}
}
