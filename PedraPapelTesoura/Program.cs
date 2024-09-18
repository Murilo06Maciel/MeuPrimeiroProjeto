bool continuar;
Random random = new Random();
string[] opcoes = { "pedra", "papel", "tesoura" };
do
{
Console.WriteLine("Escolha: Pedra, Papel ou Tesoura?");
string Usuario = Console.ReadLine().ToLower();
if (Array.Exists(opcoes, op => op == Usuario))
{
    string pc = opcoes[random.Next(opcoes.Length)];
    Console.WriteLine($"O computador escolheu: {pc}");
    if (Usuario == pc)
	{
        Console.WriteLine("Empate!");
	}
    else if ((Usuario == "pedra" && pc == "tesoura") || (Usuario == "papel" && pc == "pedra") || (Usuario == "tesoura" && pc == "papel"))
	{
        Console.WriteLine("Você ganhou!");
	}
    else
	{
        Console.WriteLine("Você perdeu!");
	}
			
}
else
{
    Console.WriteLine("Escolha inválida! Tente novamente.");
}
	Console.WriteLine("\nDeseja continuar? (1 = sim | 2= não)");
	continuar = Console.ReadLine() == "1";
}while(continuar);

