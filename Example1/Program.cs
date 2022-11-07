// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом
Console.WriteLine("Здравствуйте! Введите пятизначное число");

string number = Console.ReadLine();

void PalCheck(string number)
{
    if (number.Length > 3 && number.Length < 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
        Console.WriteLine("Это палиндром");
        }
        else Console.WriteLine("Это не палиндром");
    }
    else Console.WriteLine("Здесь больше пяти знаков");
}
PalCheck(number);