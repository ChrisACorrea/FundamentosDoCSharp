using System.Text.RegularExpressions;

namespace EditorHtml;

public class Viewer
{
	public static void Exibir(String texto)
	{
		Console.Clear();
		Console.BackgroundColor = ConsoleColor.White;
		Console.ForegroundColor = ConsoleColor.Black;
		Console.Clear();
		Console.WriteLine("MODO VISUALIZAÇÃO");
		Console.WriteLine("-----------");
		Replace(texto);
		Console.WriteLine("-----------");
		Console.ReadKey();
		Menu.Exibir();
	}

	private static void Replace(string texto)
	{
		var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
		var palavras = texto.Split(' ');

		foreach (var palavra in palavras)
		{
			if (strong.IsMatch(palavra))
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write(
					palavra.Substring(
						palavra.IndexOf('>') + 1,
						((palavra.LastIndexOf('<') - 1) - palavra.IndexOf('>'))
					)
				);
				Console.Write(" ");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write(palavra);
				Console.Write(" ");
			}
		}

		Console.WriteLine();
	}

}