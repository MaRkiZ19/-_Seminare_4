//Напишите программу, которая принимает число и выдает количество цифр в числе

int Read()
{
    System.Console.WriteLine("Input number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = Read();
System.Console.WriteLine();
string num = number.ToString();

if (number>0)
{
    System.Console.WriteLine(num.Length);
}
else
{
    System.Console.WriteLine(num.Length-1);
}