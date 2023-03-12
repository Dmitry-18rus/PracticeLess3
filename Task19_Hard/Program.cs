// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности 
//и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

Console.WriteLine ("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n;

int MetCount(int c)
{
int countNum = 0;
while (n1>=1)
{
    n1=n1/10;
    countNum++;
}
return countNum;
// Console.WriteLine($"countNum = {countNum}");
}
int count = MetCount(n1);
// Console.WriteLine($"count = {count}");

bool MetCheck(int n, int count)
{
int n2 = n;
bool check = false;

for (int i = 1; i<=(Convert.ToInt32(Math.Floor(Convert.ToDouble(count/2)))); i++)
{
    double a = Math.Floor((n2%(Math.Pow(10,(count - i+1) ))/Math.Pow(10,(count-i))));
    double b = Math.Floor((n2 % (Math.Pow(10, i)))/(Math.Pow(10,(i-1))));
    //Console.WriteLine($"a = {a}");
    //Console.WriteLine($"b = {b}");
    
    if (a == b) //повторить меняя значение 1цы в цикле
    {
        check = true;
        // Console.WriteLine($"check = {check}");
        // Console.WriteLine("да");
    }
    else
    {
        // Console.WriteLine($"check = {check}");
        // Console.WriteLine("нет");
        break;
    }
}
return check;
}
bool res = MetCheck(n, count);
void MetPrint (bool res)
{
if (res == true)
    Console.WriteLine($"Введеное число является палиндромом");
else
    Console.WriteLine($"Введеное число НЕ является палиндромом");
}
MetPrint(res);