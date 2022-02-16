using System.Text;

namespace EditorHtml;

public static class Editor
{
	public static void Exibir()
	{
		Console.Clear();
		Console.BackgroundColor = ConsoleColor.White;
		Console.ForegroundColor = ConsoleColor.Black;
		Console.Clear();
		Console.WriteLine("MODO EDIÇÂO");
		Console.WriteLine("-----------");
		Console.WriteLine();
		Iniciar();
	}

	private static void Iniciar()
	{
		var file = new StringBuilder();

		do
		{
			file.Append(Console.ReadLine());
			file.Append(Environment.NewLine);
		} while (Console.ReadKey().Key != ConsoleKey.Escape);

		Console.WriteLine("");
		Console.WriteLine("-----------");
		Console.WriteLine("DDeseja salvar o arquivo? s/n");

		string opcao = Console.ReadLine();

		switch (opcao)
		{
			case "s":
			case "S":
				Salvar(file.ToString());
				break;
			case "n":
			case "N":
				Menu.Exibir();
				break;
			default:
				Console.WriteLine("Opção Inválida.");
				Console.WriteLine("Deseja salvar o arquivo? s/n");
				break;
		}
	}

	private static void Salvar(string texto)
	{
		Console.Clear();
		Console.WriteLine("Qual caminho para salvar o arquivo?");
		var caminho = Console.ReadLine();

		using (var arquivo = new StreamWriter(caminho))
		{
			arquivo.Write(texto);
		}

		Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
		Console.ReadLine();
		Menu.Exibir();
	}

	public static string Abrir()
	{
		Console.Clear();
		Console.WriteLine("Qual o caminho do arquivo?");
		string caminho = Console.ReadLine();

		using (var file = new StreamReader(caminho))
		{
			string texto = file.ReadToEnd();
			return texto;
		}
	}
}