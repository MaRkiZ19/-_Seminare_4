Task1();

void Task1()
{
	int number1 = ReadInt("first number");
	int number2 = ReadInt("second number");

	if (IsMoreThan(number1, number2))
	{
		Console.WriteLine($"{number1} > {number2}");
	}
	else if (IsMoreThan(number2, number1))
	{
		Console.WriteLine($"{number2} > {number1}");
	}
	else
	{
		Console.WriteLine($"{number1} = {number2}");
	}
}

int ReadInt(string argument)
{
	int number;

	Console.Write($"Input {argument}: ");

	while (!int.TryParse(Console.ReadLine(), out number))
	{
		Console.WriteLine("It's not a integer number!");
		Console.Write("Try again: ");
	}

	return number;
}

bool IsMoreThan(int number1, int number2)
{
	return number1 > number2;
}
