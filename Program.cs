void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
        matr[i,j] = new Random().Next(1,10);
       } 
    }
}

void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void SortArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int a = 0; a < matr.GetLength(1)-1; a++)
            {
                if(matr[i,a] < matr[i,a+1])
                {
                    int sort = matr[i,a+1];
                    matr[i, a+1] = matr[i,a];
                    matr[i,a] = sort;
                }
            }
        }
    }
}



    System.Console.WriteLine("Введите количество строк");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов");
    int j = Convert.ToInt32(Console.ReadLine());
    int[,] num = new int [n,j];

   
FillArray(num);
 Print(num);
 SortArray(num);
 Console.WriteLine();
Print(num);