int Start()
{
    System.Console.WriteLine("Enter number ");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int a = Start();
int Summ(int a)
{
    int result = 0;
    for (int i = 0; i <= a; i++)
    {
        result += i;
    }
    return result;
}

int result = Summ(a);
System.Console.WriteLine(result);
