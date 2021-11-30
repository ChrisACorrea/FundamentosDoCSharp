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
	Console.Clear();

	Console.Write("Primeiro Valor: ");
	double v1 = Double.Parse(Console.ReadLine());

	Console.Write("Segundo Valor: ");
	double v2 = Double.Parse(Console.ReadLine());

	Console.WriteLine();

	double soma = v1 + v2;

	Console.WriteLine($"O resultado da soma é {soma}");
	Console.ReadKey();
	Menu();
}

static void Subtracao() {
	Console.Clear();

	Console.Write("Primeiro Valor: ");
	double v1 = Double.Parse(Console.ReadLine());

	Console.Write("Segundo Valor: ");
	double v2 = Double.Parse(Console.ReadLine());

	Console.WriteLine();

	double subtracao = v1 - v2;

	Console.WriteLine($"O resultado da subtracao é {subtracao}");
	Console.ReadKey();
	Menu();
}

static void Multiplicacao() {
	Console.Clear();

	Console.Write("Primeiro Valor: ");
	double v1 = Double.Parse(Console.ReadLine());

	Console.Write("Segundo Valor: ");
	double v2 = Double.Parse(Console.ReadLine());

	Console.WriteLine();

	double multiplicacao = v1 * v2;

	Console.WriteLine($"O resultado da multiplicacao é {multiplicacao}");
	Console.ReadKey();
	Menu();
}

static void Divisao() {
	Console.Clear();

	Console.Write("Primeiro Valor: ");
	double v1 = Double.Parse(Console.ReadLine());

	Console.Write("Segundo Valor: ");
	double v2 = Double.Parse(Console.ReadLine());

	Console.WriteLine();

	double divisao = v1 / v2;

	Console.WriteLine($"O resultado da divisao é {divisao}");
	Console.ReadKey();
	Menu();
}

static void Sair() {
	Console.WriteLine("Saindo...");
	System.Environment.Exit(0);
}