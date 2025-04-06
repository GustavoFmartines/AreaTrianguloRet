        Double area;
        Double bs;
        Double altura;

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.BackgroundColor = ConsoleColor.Cyan;

Console.WriteLine("--- Calculo da Área do Triângulo ---");

    Console.ResetColor();

Console.Write(@"
Digite o valor da base do triângulo: ");
bs = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o valor da altura: ");
altura = Convert.ToDouble(Console.ReadLine())!;

        area = (bs * altura) / 2;

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.BackgroundColor = ConsoleColor.Cyan;

Console.WriteLine("--- Area do Triângulo ---");

    Console.ResetColor();

Console.WriteLine($@"
Base: {bs}");
Console.WriteLine($"Altura: {altura}");
Console.WriteLine($"O valor da área do triangulo é {area}");
