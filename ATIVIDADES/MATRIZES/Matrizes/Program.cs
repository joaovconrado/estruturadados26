//vetores multidimensionais

//vetor bi-dimensional
int[, ] numbersBi = new int[5, 2];

//vetor tri-dimensional
int[, , ] numbersTri = new int[5, 4, 3];

//podemos combinar a declaração com a inicialização
//exemplo de um 4x3
int[, ] newNumbersBi = new int[, ]{
    { 9, 5, -9 },
    { -11, 4, 0 },
    { 6, 115, 3 },
    {-12, -9, 7 },
    { 1, -6, -1 }
};

//percorrenfo a matriz. exemplo de repetição for encadeada
//nested/chained for
for(int i = 0; i < newNumbersBi.GetLength(0); i++)
{
    for(int j = 0; j < newNumbersBi.GetLength(1); j++)
    {
        Console.Write($"[{newNumbersBi[i, j]}]");
    }
    Console.WriteLine("");
}

//jagged arrays ou arrei de jegues
//vetor de vetores

int[][] jaggedNumbers = new int[4][];

//atribuindo valores
jaggedNumbers[0] = new int[] { 9, 5, -9 };
jaggedNumbers[1] = new int[] { 0, -3, 12, 51, -3 };
jaggedNumbers[3] = new int[] { 51 };

//declaração com inicialização
int[][] jaggedNumbers2 =
{
    new int[] { 0, 1, 2 },
    new int[] { 3, 4, 5, 6 },
    new int[] { 7, 8, 9, 10 },
};

//para acessar uma posição especifica
int n = jaggedNumbers[1][2];
jaggedNumbers[1][2] = 22;

Console.WriteLine("n = " + n);
Console.WriteLine("jaggedNumbers[1][2] = " + jaggedNumbers[1][2]);