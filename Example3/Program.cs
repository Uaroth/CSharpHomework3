// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Здравствуйте. Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

void AllCubes(int number)
{
    if (number > 1)
    {
        for (int i = 1; i <= number; i++)
        {
        int result = i * i * i;
        Console.Write($"{result}, ");
        }
    }
    else Console.WriteLine("Для списка кубов от 1 до N нужно целое число N больше 1");
}
AllCubes(numberN);