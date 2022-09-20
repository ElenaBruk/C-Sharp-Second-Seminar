// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int CreateNumber()
{
    return new Random().Next(100, 1000);
}
int NewDigit(int number)
{
    int Sot = number / 100;
    int Ed = number % 10;
    return Sot * 10 + Ed;
}

int a = CreateNumber();
Console.WriteLine(a);
int b = NewDigit(a);
Console.WriteLine(b);