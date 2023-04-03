void DVUMAS (int[,] mas)
{
        for(int i = 0; i < mas.GetLength(0); i++)
    {
            for(int j = 0; j < mas.GetLength(1); j++)
            mas[i, j] = new Random().Next(1, 100);
    }
}

void POKADVUMAS (int[,] mas)
{
        for(int i = 0; i < mas.GetLength(0); i++)
    {
            for(int j = 0; j < mas.GetLength(1); j++)
            Console.Write($"{mas[i,j]} \t");
            Console.WriteLine();
    }   
}

void SR (int[,]mas)
{
        for (int j = 0; j < mas.GetLength(1); j++)
          {
            double sum = 0;
            double res = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            sum += mas[i,j];
            Console.WriteLine($"Среднее арифмитическое {j+1} столбца: {res = sum / mas.GetLength(0)}");           
          }
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] s = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
int[,]mas = new int[s[0], s[1]];
DVUMAS(mas);
POKADVUMAS(mas);
SR(mas);

