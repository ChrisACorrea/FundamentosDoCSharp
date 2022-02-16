namespace EditorHtml;

public static class Menu
{
	private static readonly char VERTICE = '+';
	private static readonly char ARESTA_LATERAL = '|';
	private static readonly char ARESTA_SUPERIOR_E_INFERIOR = '-';
	private static readonly char COLUNA_VAZIA = ' ';
	private static readonly string DIVISOR_OPCOES = "====================";
	public static void Exibir()
	{
		Console.Clear();
		Console.BackgroundColor = ConsoleColor.Blue;
		Console.ForegroundColor = ConsoleColor.Black;
		Console.Clear();

		DesenharTela(50, 10);
		EscreverOpcoes();

		var opcao = short.Parse(Console.ReadLine());
		ManipularOpcoesDoMenu(opcao);
	}

	private static void DesenharTela(short quantidadeColunas, short quantidadeLinhas)
	{
		DesenharLinha(quantidadeColunas, VERTICE, ARESTA_SUPERIOR_E_INFERIOR);

		for (short linha = 0; linha < quantidadeLinhas; linha++)
		{
			DesenharLinha(quantidadeColunas, ARESTA_LATERAL, COLUNA_VAZIA);
		}

		DesenharLinha(quantidadeColunas, VERTICE, ARESTA_SUPERIOR_E_INFERIOR);
	}

	private static void DesenharLinha(short quantidadeColunas, char aparenciaBorda, char aparenciaColuna)
	{
		Console.Write(aparenciaBorda);
		for (short coluna = 0; coluna < quantidadeColunas; coluna++)
			Console.Write(aparenciaColuna);

		Console.Write(aparenciaBorda);
		Console.Write(Environment.NewLine);
	}

	private static void EscreverOpcoes()
	{
		Console.SetCursorPosition(2, 1);
		Console.WriteLine("Editor HTML");
		Console.SetCursorPosition(2, 2);
		Console.WriteLine(DIVISOR_OPCOES);
		Console.SetCursorPosition(2, 3);
		Console.WriteLine("Selecione uma opção abaixo");
		Console.SetCursorPosition(2, 5);
		Console.WriteLine("1 - Novo Arquivo");
		Console.SetCursorPosition(2, 6);
		Console.WriteLine("2 - Abrir");
		Console.SetCursorPosition(2, 7);
		Console.WriteLine("0 - Sair");
		Console.SetCursorPosition(2, 8);
		Console.Write("Opção: ");
	}

	private static void ManipularOpcoesDoMenu(short opcao)
	{
		switch (opcao)
		{
			case 1:
				Editor.Exibir();
				break;
			case 2:
				Viewer.Exibir(Editor.Abrir());
				break;
			case 0:
				{
					Console.Clear();
					Environment.Exit(0);
					break;
				}
			default:
				Exibir();
				break;
		}
	}
}