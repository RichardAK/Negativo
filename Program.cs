int numero;

Console.Write("Digite um número:");
numero = Convert.ToInt32(Console.ReadLine());

if (numero < 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Você digitou um número negativo");
    Console.Beep();
}

Console.ResetColor();
