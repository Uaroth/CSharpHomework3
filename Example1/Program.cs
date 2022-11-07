// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом
Console.WriteLine("Здравствуйте! Введите пятизначное число");

string number = Console.ReadLine();

void PalCheck(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
        {
        Console.WriteLine("Это число - палиндром");
        }
    else Console.WriteLine("Это число - не палиндром");
}
PalCheck(number);