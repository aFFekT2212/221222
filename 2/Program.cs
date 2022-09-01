int n = 5;
int m = 5;

int[,] mas = new int[n, m];
for (int i = 0; i < n; i++)
    for (int j =0; j < m; j++)
        mas[i, j] = new Random(). Next(0,100);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write($"{mas[i, j]} ");
    Console.WriteLine();
}

Console.WriteLine("Выберите вариант: 1 - получить индекс, 2 - получить значение");
int variant = int.Parse(Console.ReadLine());
switch (variant)
{
    case 1:
        bool flag = false;
        int c = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (mas[i, j] == c)
                {
                    Console.WriteLine($"{i}, {j}");
                    flag = true;
                }
        if (!flag) Console.WriteLine("Такого элемента нет");
        break;

    case 2:
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a >= 0 && a < n && b > +0 && b < m)
            Console.WriteLine(mas[a, b]);
        break;
    default:
        Console.WriteLine("Ошибка!");
        break;
}

