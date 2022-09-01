int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

double[,] mas = new double[n, m];
for (int i = 0; i < n; i++)
    for (int j = 0; j < m; j++) 
        mas[i,j] = new Random().Next(-1000, 1000) / 10.0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write($"{mas[i, j]} ");
    Console.WriteLine();
}
