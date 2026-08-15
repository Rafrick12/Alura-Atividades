int resp = 7;

Console.Write("Tente advinhar o numero secreto de 0 a 100: ");
int chute = int.Parse(Console.ReadLine()!);

if(chute >= 0 && chute <= 100)
{
    if(chute == resp)
    {
        Console.WriteLine("\nParabens você acertou");
    }
    else { Console.WriteLine("\nVocê errou =(");
    }
}
else
{
    Console.WriteLine("\nNumero invalido!!");
}