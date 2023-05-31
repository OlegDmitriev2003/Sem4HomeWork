Console.Clear();
int sum = 0;
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);
while (Num > 0)
{
    sum = sum + Num%10;
    Num = Num/10;
}
Console.Write($"Cумма цифр - {sum} ");