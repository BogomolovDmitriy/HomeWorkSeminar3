void GetPrime(int num)
{
    int IsPrime(int number)
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return -1;
            }
        }
        Console.Write(number + " ");
        return number;
    }
    
    for (int i = 2; i <= num; i++)
    {
        IsPrime(i);
    }
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

GetPrime(N);


