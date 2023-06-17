// Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


int ReadInt(string message)
{
    System.Console.Write($"{message}");
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool ValidateNumber(int number)
{
    if (number < 100000 && number > 9999)
    {
        return true;
    }

    System.Console.WriteLine("Вы ввели не целое пятизначное число");
    return true;
}
int number = ReadInt("Введите целое пятизначное число ");
ValidateNumber(number);
int tempOne = 0;
int tempTwo = 0;
int tempThree = 0;
int tempFour = 0;
if (number > tempOne)
{
    tempOne = number % 10;
    tempTwo = number / 10000;
    tempThree = number % 100 / 10;
    tempFour = (number / 1000) % 10;
}
if (tempOne == tempTwo || tempThree == tempFour)
{
    System.Console.WriteLine("Это палиндром");
}
else
{
    System.Console.WriteLine("это не палиндром");
}







