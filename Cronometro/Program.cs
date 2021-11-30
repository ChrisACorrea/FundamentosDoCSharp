Menu();

static void Menu()
{
	Console.Clear();
	Console.WriteLine("S = Segundo => 10s = 10 segundos");
	Console.WriteLine("M = Minuto => 1m = 1 minuto");
	Console.WriteLine("0 = Sair");
	Console.WriteLine("Quanto tempo deseja contar?");

	string dado = Console.ReadLine().ToLower();
	char tipo = char.Parse(dado.Substring(dado.Length - 1, 1));
	int tempo = int.Parse(dado.Substring(0, dado.Length - 1));
	int multiplicador = 1;

	if (tipo == 'm')
		multiplicador = 60;

	if (tempo == 0)
		System.Environment.Exit(0);

	PreInicio(tempo * multiplicador);

}

static void PreInicio(int tempo)
{
	Console.Clear();
	Console.WriteLine("Preparar...");
	Thread.Sleep(1000);
	Console.WriteLine("Apontar...");
	Thread.Sleep(1000);
	Console.WriteLine("Fogo...");
	Thread.Sleep(1000);

	Iniciar(tempo);
}

static void Iniciar(int tempo)
{
	int tempoAtual = 0;

	while (tempoAtual < tempo)
	{
		Console.Clear();
		tempoAtual++;
		Console.WriteLine(tempoAtual);
		Thread.Sleep(1000);
	}

	Console.Clear();
	Console.WriteLine("Cronômetro finalizado!");
	Thread.Sleep(2000);
	Menu();
}