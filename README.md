# O QUE É?

Pedra, papel e tesoura, também chamado em algumas regiões do Brasil de jokenpô, é um jogo de mãos recreativo e simples para duas ou mais pessoas, que não requer equipamentos nem habilidade. O jogo é frequentemente empregado como método de seleção, assim como lançar moedas, jogar dados, entre outros.

<img src="/imagens/jogo representação.png">

# COMO JOGAR:

- Escolha entre **pedra**, **papel** ou **tesoura**.
- O computador irá sortear entre os três.

- Pedra perde para papel;
- Papel perde para tesoura;
- Tesoura perde para a pedra;

- Se você escolher algo que vence a escolha da máquina, você vence. Caso contrário, você perde.

<img src="/imagens/jogo 2.png">
<img src="/imagens/jogo final.png">

# COMO CONSTRUIR O JOGO?

### JOGO CONSTRUIDO NO C#

- Precisamos entender que para criar um código, temos que informar as variáveis. Neste exercício, temos que colocar uma classe **RAMDON**, responsável por gerar números aleatórios. Temos que ter também um Array do tipo string para colocar na mesma variável os nomes "pedra", "papel" e "tesoura". Após isso podemos usar a condição __if__, e __else__ para configurar de acordo com as regras do jogo.

### PASSO A PASSO

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

<img src="/imagens/código.png"> 