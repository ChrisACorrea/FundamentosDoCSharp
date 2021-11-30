Menu();

static void Menu() {
	Console.Clear();
	Console.WriteLine("O que deseja fazer?");
	Console.WriteLine("1 - Soma");
	Console.WriteLine("2 - Subtração");
	Console.WriteLine("3 - Multiplicação");
	Console.WriteLine("4 - Divisão");
	Console.WriteLine("0 - Sair");

	Console.WriteLine("--------------------");
	Console.Write("Selecione a opção: ");
	short res = short.Parse(Console.ReadLine());

	switch (res)
	{
		case 1:
			Soma();
			break;
		case 2:
			Subtracao();
			break;
		case 3:
			Multiplicacao();
			break;
		case 4:
			Divisao();
			break;
		case 0:
			Sair();
			break;
		default:
			Menu();
			break;
	}
}

static void Soma() {
	double[] valoresRecebidos = ReceberValores();

	double soma = valoresRecebidos[0] + valoresRecebidos[1];

	Console.WriteLine($"O resultado da soma é {soma}");
	Console.ReadKey();
	Menu();
}

static void Subtracao() {
	double[] valoresRecebidos = ReceberValores();

	double subtracao = valoresRecebidos[0] - valoresRecebidos[1];

	Console.WriteLine($"O resultado da subtração é {subtracao}");
	Console.ReadKey();
	Menu();
}

static void Multiplicacao() {
	double[] valoresRecebidos = ReceberValores();

	double multiplicacao = valoresRecebidos[0] * valoresRecebidos[1];

	Console.WriteLine($"O resultado da multiplicação é {multiplicacao}");
	Console.ReadKey();
	Menu();
}

static void Divisao() {
	double[] valoresRecebidos = ReceberValores();

	double divisao = valoresRecebidos[0] / valoresRecebidos[1];

	Console.WriteLine($"O resultado da divisão é {divisao}");
	Console.ReadKey();
	Menu();
}

static void Sair() {
	Console.WriteLine("Saindo...");
	System.Environment.Exit(0);
}

static double[] ReceberValores() {
	double[] valores = new double[2];
	
	Console.Clear();

	Console.Write("Primeiro Valor: ");
	valores[0] = Double.Parse(Console.ReadLine());

	Console.Write("Segundo Valor: ");
	valores[1] = Double.Parse(Console.ReadLine());

	Console.WriteLine();

	return valores;
}