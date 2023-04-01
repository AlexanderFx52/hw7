void DVUMAS (double[,] mas)
{
        for(int i = 0; i < mas.GetLength(0); i++)
    {
            for(int j = 0; j < mas.GetLength(1); j++)
            mas[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
    }
}

void POKADVUMAS (double[,] mas)
{
        for(int i = 0; i < mas.GetLength(0); i++)
    {
            for(int j = 0; j < mas.GetLength(1); j++)
            Console.Write($"{mas[i,j]} \t");
            Console.WriteLine();
    }   
}



Console.Clear();
Console.Write("Введите размерность массива: ");
int[] s = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
double[,]mas = new double[s[0], s[1]];
DVUMAS(mas);
POKADVUMAS(mas);


