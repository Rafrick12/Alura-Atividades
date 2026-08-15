Console.Write("Digite um numero qualquer: ");
int numero = int.Parse(Console.ReadLine()!);

if( numero % 2 != 0)
{
    Console.WriteLine("O número digitado é impar");
}else
{
    Console.WriteLine("O numero digitado e par");
}