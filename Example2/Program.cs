// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве
// Формула: AB = √((xb - xa)^2 + (yb - ya)^2 + (zb - za)^2)

Console.WriteLine("Введите координаты x, y, z первой точки");
double numX1 = (Console.ReadLine());
double numY1 = (Console.ReadLine());
double numZ1 = (Console.ReadLine());

Console.WriteLine("Введите координаты x, y, z второй точки");
double numX2 = (Console.ReadLine());
double numY2 = (Console.ReadLine());
double numZ3 = (Console.ReadLine());

double Distance (double numX1, double numY1, double numZ1,
                 double numX2, double numY2, double numZ2)
        {
            double result = Math.Sqrt(Math.Pow(numX2 - numX1, 2)
             + Math.Pow(numY2 - numY1, 2) 
             + Math.Pow(numZ2 - numZ1, 2));

            Console.WriteLine($"Расстояние между точками равно {result} ");
        }
Distance (numX1, numY1, numZ1, numX2, numY2, numZ2);