int n = 5;
int m = 5;

int[,] mas = new int[n, m];
for (int i = 0; i < n; i++)
    for (int j = 0; j < m; j++)
        mas[i, j] = new Random().Next(0, 10);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write($"{mas[i, j]} ");
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
        sum += mas[j, i];
    Console.WriteLine(sum); 
}
    