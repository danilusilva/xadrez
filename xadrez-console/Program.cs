using xadrez;
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

//try
//{
//Tabuleiro tab = new Tabuleiro(8, 8);

//tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
//tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 7));
//tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(7, 5));

//Tela.imprimirTabuleiro(tab);
PosicaoXadrez pos = new PosicaoXadrez('a', 7);
Console.WriteLine(pos);


//}
//catch (TabuleiroException e)
//{
//    Console.WriteLine(e.Message);
//}

Console.ReadLine();


