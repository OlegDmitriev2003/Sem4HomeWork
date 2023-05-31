Console.Clear();
Console.Write("Введите число A: ");
int Num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int Power = int.Parse(Console.ReadLine()!);
Console.WriteLine(Math.Pow(Num,Power));