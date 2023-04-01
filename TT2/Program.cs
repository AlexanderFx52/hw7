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

int RAZ (int[,] raz)
{
    Console.Write("Введите номер строки: ");
        int a = int.Parse(Console.ReadLine()!);
        a -= 1;
    Console.Write("Введите номер столбца: ");
        int b = int.Parse(Console.ReadLine()!);
        b-= 1;
    while (a >= raz.GetLength(0) || b >= raz.GetLength(1))
{      
    Console.WriteLine("Вы вышли за пределы массива, попробуйте ввести еще раз");
    Console.Write("Введите номер строки: ");
        a = int.Parse(Console.ReadLine()!);
        a -= 1;
    Console.Write("Введите номер столбца: ");
        b = int.Parse(Console.ReadLine()!);
        b -= 1;
}
        return raz[a,b];
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] s = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
int[,]mas = new int[s[0], s[1]];
DVUMAS(mas);
POKADVUMAS(mas);
Console.WriteLine(RAZ(mas));


