Console.Clear();


int N1, N2, N3;
int NumeroMaior;

Console.Write("--- Maior De Três ---\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Digite Seu Primero Numero...:");
N1 = Convert.ToInt32(Console.ReadLine());

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Digite Seu Segundo Numero...:");
N2 = Convert.ToInt32(Console.ReadLine());

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Digite Seu Terçeiro Numero...:");
N3 = Convert.ToInt32(Console.ReadLine());

Console.ResetColor();

 

if (N1 > N2)
{
    if (N1 > N3)
    {
        NumeroMaior = N1;
    }
    else
    {
        NumeroMaior = N3;
    }
}
else
{
    if (N2 > N3)
    {
        NumeroMaior = N2;
    }
    else
    {
        NumeroMaior = N3;
    }
}
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"\nMaior número: {NumeroMaior}");
Console.ResetColor();