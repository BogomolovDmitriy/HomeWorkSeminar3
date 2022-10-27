//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double VectorLength(int ax, int ay, int az, int bx, int by, int bz)
{
    return (Math.Sqrt((bx - ax)*(bx - ax) + (by - ay)*(by - ay) + (bz - az)*(bz - az)));
}

int[] dotA = new int[3];
int[] dotB = new int[3];

//Координаты точки А
dotA[0] = new Random().Next(-10, 11);
dotA[1] = new Random().Next(-10, 11);
dotA[2] = new Random().Next(-10, 11);

//Координаты точки B
dotB[0] = new Random().Next(-10, 11);
dotB[1] = new Random().Next(-10, 11);
dotB[2] = new Random().Next(-10, 11);

// //Координаты точки А
// dotA[0] = 3;
// dotA[1] = 6;
// dotA[2] = 8;

// //Координаты точки B
// dotB[0] = 2;
// dotB[1] = 1;
// dotB[2] = -7;

Console.Write("Координаты точки А: ");
for (int i = 0; i < dotA.Length; i++)
{
    Console.Write(dotA[i] + " ");
}

Console.WriteLine();
Console.Write("Координаты точки В: ");
for (int i = 0; i < dotB.Length; i++)
{
    Console.Write(dotB[i] + " ");
}

Console.WriteLine();
Console.Write("Расстояние между точками: ");
Console.WriteLine(VectorLength(dotA[0], dotA[1], dotA[2], dotB[0], dotB[1], dotB[2]));