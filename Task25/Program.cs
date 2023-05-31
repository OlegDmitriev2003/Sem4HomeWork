Console.Clear();
int N = 1;
Console.Write("Введите число A: ");
int Num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int Power = int.Parse(Console.ReadLine()!);
while (N < Power)
    {
        Num = Num*Num;
        N++;
    }
    Console.Write(Num);