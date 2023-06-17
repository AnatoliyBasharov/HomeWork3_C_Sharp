// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125



int ReadInt(string message)
{
    System.Console.Write($"{message}");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int numb = ReadInt("Введите число ");
int temp = 1;
while (temp <= numb)
{
    int result = temp * temp * temp;
    System.Console.Write($"{result} ");
    temp++;
}