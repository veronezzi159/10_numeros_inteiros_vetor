int[] vetor = new int[10], pares = new int[10], impares = new int[10];
int p = 0, im = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i+1}º número");
    vetor[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Este é o vetor lido");
for (int i = 0; i < 10; i++)
{
    Console.Write(vetor[i] + " ");
}

Console.WriteLine("\nVetor de trás pra frente");
for(int i = 9;i >= 0; i--)
{
    Console.Write(vetor[i] + " ");
}
Console.WriteLine("\nPrimeira metade do vetor");
for (int i = 0;i < 5;i++)
{
    Console.Write(vetor[i] + " ");
}

Console.WriteLine("\nSegunda metade");
for (int i = 5; i < 10; i++)
{
    Console.Write(vetor[i] + " ");
}
for (int i = 0;i < 10; i++)
{
    if (vetor[i] != 0)
    {
        if (vetor[i] % 2 == 0)
        {
            pares[p] = vetor[i];
            p++;
        } else
        {
            impares[im] = vetor[i];
            im++;
        }
    }
}
Console.WriteLine("\nPares: ");
for (int i = 0; i < p; i++)
{
    Console.Write(pares[i] + " ");
}

Console.WriteLine("\nImpares: ");
for (int i = 0; i < im; i++)
{
    Console.Write(impares[i] + " ");
}