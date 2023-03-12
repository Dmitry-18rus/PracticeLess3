// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Введите величину пространства N");
int N = Convert.ToInt32(Console.ReadLine());
double MetInput (int N)
{
double res1 = 0;
for (int i = 1; i<=N; i++)
{
    Console.WriteLine("Введите координату первой точки ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите координату второй точки ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    res1 = res1 + (k1-k2)*(k1-k2);
    //Console.WriteLine("res1 ="+ res1);
}
return res1;
}
double resultInput = MetInput(N);

void MetResult (double resultInput)
{
double res2 = Math.Sqrt(resultInput);
Console.WriteLine($"Расстояние между точками в {N} мерном пространстве = "+ res2);
// Console.WriteLine("res2 ="+ res2);
}
MetResult(resultInput);

