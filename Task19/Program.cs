// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
double n = Convert.ToInt32(Console.ReadLine());

double n1 = n;
int countNum = 0;

int CountMetod(int c)
{
    
    while (n1 > 1)
    {
        n1 = n1 / 10;
        countNum++;
    }
    return countNum;
}
int count = CountMetod(countNum);

// Console.WriteLine(count);

bool Check(int count)
{
    bool check = false;
    if (count == 5)
    {
        if (Convert.ToInt32(n % 10) == Convert.ToInt32(Math.Floor(n / 10000)))
        {
            double n2 = n % 100;
            int n3 = Convert.ToInt32(Math.Floor(n2 / 10));
            double n4 = n % 10000;
            int n5 = Convert.ToInt32(Math.Floor(n4 / 1000));
            if (n3 == n5)
            {
                check = true;
                // Console.WriteLine($"да ");
            }
        }
        Console.WriteLine($"Результат проверки - {check}");
    }
    else
        Console.WriteLine("Введено неверное число");
    return check;
        
}
Check(count);

