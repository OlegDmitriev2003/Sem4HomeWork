Console.Clear();
int N = 1;
Console.Write("Введите число A: ");
int Num = int.Parse(Console.ReadLine()!);
int HoldNum = Num;
Console.Write("Введите число B: ");
int Power = int.Parse(Console.ReadLine()!);
while (N < Power)
    {
        Num = HoldNum*Num;
        N++;
    }
    Console.Write(Num);