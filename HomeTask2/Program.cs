// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int ReadInt(String message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
double Length(int x, int y, int z)
{
    double temp = (x * x) + (y * y) + (z * z);
    return Math.Sqrt(temp);
}
int x1 = ReadInt("Введите координату Х первой точки ");
int y1 = ReadInt("Введите координату y первой точки ");
int z1 = ReadInt("Введите координату z первой точки ");
int x2 = ReadInt("Введите координату Х второй точки ");
int y2 = ReadInt("Введите координату y второй точки ");
int z2 = ReadInt("Введите координату z второй точки ");

double Distans = Length(x1-x2, y1-y2, z1-z2);
System.Console.WriteLine($"Расстояние между двумя точками {Distans}");