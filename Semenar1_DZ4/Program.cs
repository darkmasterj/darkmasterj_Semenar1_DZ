Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine());
    for (int i = n; i <= m; i++)
        {
    if (i % 2 == 0) 
        Console.Write(i + " ");
        }