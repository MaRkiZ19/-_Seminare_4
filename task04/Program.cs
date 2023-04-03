//Принимаем число N и выдает произведение чисел от 1 до N. 4->24; 4->120

int Start()
{
    System.Console.WriteLine("Введите число");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int a = Start();

int Work(int a)
{
    int result = 1;
    for (int i=1; i<=a; i++)
    {
        result = result * i;
    }
    return result;
}

int result = Work(a);
System.Console.WriteLine(result);
