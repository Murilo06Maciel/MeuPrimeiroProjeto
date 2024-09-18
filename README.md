# O QUE É?

O Jogo da Velha faz parte dos jogos conhecidos como “família do moinho” ou “trilha”, em que o objetivo é posicionar as peças de modo que formem uma linha reta.

# COMO JOGAR:

- Escolha entre **pedra**, **papel** ou **tesoura**.
- O computador irá sortear entre os três.

- Pedra perde para papel;
- Papel perde para tesoura;
- Tesoura perde para a pedra;

- Se você escolher algo que vence a escolha da máquina, você vence. Caso contrário, você perde.

# COMO CONSTRUIR O JOGO?

### JOGO CONSTRUIDO NO C#

- Indique a variavel "continuar" como bool: "bool continuar;"
- Informe: "Random random = new Random();"
- Indique a Array opções do tipo string: "string[] opcoes = { "pedra", "papel", "tesoura" };"
- Peça ao usuário informar a sua escolha: "Console.WriteLine("Escolha: Pedra, Papel ou Tesoura?");" e coloque para ler a escolha: "string Usuario = Console.ReadLine().ToLower();"
- Use o __if__ em: "if (Array.Exists(opcoes, op => op == Usuario))" LEMBRE SE DE ABRIR E FECHAR CHAVES PARA O SEU FUNCIONAMENTO!
- escreva: "string pc = opcoes[random.Next(opcoes.Length)];" para a máquina escolher entre pedra, papel ou tesoura
- Use o __if__ para verificar se a escolha do usuário é a mesma da máquina: "if (Usuario == pc)" e coloque para imprimir: **Empate**
- Caso não for crie um __else if__ para verificar se a escolha do usuário vence a escolha da máquina no jogo:"else if ((Usuario == "pedra" && pc == "tesoura") || (Usuario == "papel" && pc == "pedra") || (Usuario == "tesoura" && pc == "papel"))" e informar: **Vitória** "Console.WriteLine("Você ganhou!");"
- Caso negativo, use o __else__, informar: **Derrota** "Console.WriteLine("Você perdeu!");"
- Informe um __else__ se a escolha do usuário não existir, coloque para escrever opção inválida: "Console.WriteLine("Escolha inválida! Tente novamente.");"

# CODIGO FINAL:
using System;

class Program
{
    static void Main()
    {
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
    }
}