Console.Clear();
int i = 0;
int[] array = new int [8];
while (i < array.Length)
{
    Console.Write("Введите число: ");
    array[i] = int.Parse(Console.ReadLine()!);
    i++;
}
    Console.WriteLine($"Результат - [{string.Join(", ", array)}]");