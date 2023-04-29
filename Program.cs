    const double LimiteAguasContinentaisEmKG = 10;
    const double LimiteAguasMarinhas = 15;

    const decimal MultaExcessoPeso = 1000;
    const decimal MultaPorQuiloExcedido = 20;

    const string AGUAS_MARINHAS = "M";
    const string AGUAS_CONTINENTAIS = "C";

    double PesodoPescaDoEmKG;
    string LocalPesca;

    Console.Clear();

    Console.WriteLine("--- Pesca Amadora ---\n");

    Console.WriteLine("Peso (em kg)...: ");

    PesodoPescaDoEmKG = Convert.ToDouble(Console.ReadLine()!);

    Console.WriteLine("Águas [c]ontinentais ou [m]arinhas?");
    LocalPesca = Console.ReadLine()!
                            .Trim()
                            .Substring(0, 1)
                            .ToUpper();
    
    Console.WriteLine();

    if (LocalPesca != AGUAS_CONTINENTAIS && LocalPesca != AGUAS_MARINHAS) 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Local não reconhecido.");
        Console.ResetColor();
        return;
    }
    
        if((LocalPesca == AGUAS_CONTINENTAIS
        && PesodoPescaDoEmKG <= LimiteAguasContinentaisEmKG)
        ||
        (LocalPesca == AGUAS_MARINHAS
        && PesodoPescaDoEmKG <= LimiteAguasMarinhas))
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Pescaria dentro dos limites legais.");
            Console.ResetColor();
            return;
        }
        
        double PesoPermitido;

        if (LocalPesca == AGUAS_CONTINENTAIS)
        {
            PesoPermitido = LimiteAguasContinentaisEmKG;
        }
        else
        {
            PesoPermitido = LimiteAguasContinentaisEmKG;
        }

        double PesoEmExcesso = PesodoPescaDoEmKG - PesoPermitido;

        decimal Multa = MultaExcessoPeso + 
                        (MultaPorQuiloExcedido * Convert.ToDecimal(PesoEmExcesso));

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine($"Pescaria excede os limites legais em {PesoEmExcesso}kg.");
        Console.WriteLine($"Sujeito a multa de {Multa:C2}.");

        Console.ResetColor();
    
    