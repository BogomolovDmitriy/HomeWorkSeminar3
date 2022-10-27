//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeNumberTable(int number)
{
    double cubenumber;
    for (int i = 1; i <= number; i++)
    {
        cubenumber = Math.Pow(i, 3);
        Console.Write(cubenumber + " ");
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
CubeNumberTable(number);
