//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.[1,0,1,1,0,1,0,0]

int [] numbers = new int[8];
int length = numbers.Length;

Method (length);
void Method (int length)

{
    for (int i = 0; i < length; i++)
    {
       numbers [i] = new Random().Next(0,2);
       System.Console.Write(numbers [i]);
    }
}
