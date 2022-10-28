//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double VectorLength(int ax, int ay, int az, int bx, int by, int bz)
{
    return (Math.Sqrt((bx - ax)*(bx - ax) + (by - ay)*(by - ay) + (bz - az)*(bz - az)));
}

int[] dotA = new int[3];
int[] dotB = new int[3];

int maxValue = 10;
int minValue = - 10;

void CreateCoordinateDot3DRandom(int[] nameArray)
{
    for (int i = 0; i < 3; i++)
    {
        nameArray[i] = new Random().Next(minValue, maxValue);
    }
}

CreateCoordinateDot3DRandom(dotA);
CreateCoordinateDot3DRandom(dotB);

// //Координаты точки А
// dotA[0] = 7;
// dotA[1] = -7;
// dotA[2] = 3;

// //Координаты точки B
// dotB[0] = 3;
// dotB[1] = 8;
// dotB[2] = 1;

void CoordinateOutput(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Координаты точки А: ");
CoordinateOutput(dotA);

Console.WriteLine();
Console.Write("Координаты точки В: ");
CoordinateOutput(dotB);

Console.WriteLine();
Console.Write("Расстояние между точками: ");
Console.WriteLine(VectorLength(dotA[0], dotA[1], dotA[2], dotB[0], dotB[1], dotB[2]));