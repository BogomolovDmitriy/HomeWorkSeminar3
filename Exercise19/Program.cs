//Задача 19
//Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

void PolindromNumber(int number)
{
    if(number >= 0 && number < 10)
    {
        Console.WriteLine($"Число {number} - полиндром.");
    }
    else
    {
        int GetLength(int number)
        {
            int n = 0;
            while (number > 0)
            {
                number /= 10;
                n++;
            }
            return n;
        }

        int num = number;

        int numlength = GetLength(number);
        int[] digits = new int[numlength];
        for (int i = numlength - 1; i >= 0; i--)
        {
            digits[i] = num % 10;
            num /= 10;
        }

        int count = 0;
        for (int j = 0; j < (numlength / 2); j++)
        {
            if (digits[j] == digits[numlength - j - 1])
            {
                count++;
            }
        }

        if (count == (numlength / 2))
        {
            Console.WriteLine($"Число {number} - полиндром.");
        }
        else
        {
            Console.WriteLine($"Число {number} - НЕ полиндром.");
        }
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Введено число: {number}.");
PolindromNumber(number);