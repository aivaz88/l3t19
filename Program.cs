Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

int num1 = num%10;
int num2 = num/10%10;
int num4 = num/1000%10;
int num5 = num/10000;

if (num1 == num5 && num2 == num4)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}