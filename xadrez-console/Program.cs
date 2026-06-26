using xadrez;
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

try
{
	PartidaDeXadrez partida = new PartidaDeXadrez();

	while (!partida.terminada)
	{
		try
		{
			Console.Clear();
			Tela.imprimirTabuleiro(partida.Tab);
			
			System.Console.WriteLine();
			Console.Write("Origem: ");
			Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

			// bool[,] posicoesPossiveis = partida.Tab.peca(origem).movimentosPossiveis();

			// Console.Clear();
			// Tela.imprimirTabuleiro(partida.Tab, posicoesPossiveis);

			Console.Write("Destino: ");
			Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

			partida.executaMovimento(origem, destino);
		}
		catch (TabuleiroException e)
		{
			Console.WriteLine(e.Message);
			Console.ReadLine();
		}
	}
}
catch (TabuleiroException e)
{

    Console.WriteLine(e.Message);
}

Console.ReadLine();