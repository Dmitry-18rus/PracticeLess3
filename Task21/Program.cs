// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату первой точки x1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату первой точки y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату первой точки z1");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату второй точки x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату второй точки y2");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату второй точки z2");
double z2 = Convert.ToDouble(Console.ReadLine());

double MetDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
double res = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));
Console.WriteLine("расстояние между точками ="+ res);
return res;
}
MetDistance(x1,y1,z1, x2,y2,z2);




// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.
// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.


