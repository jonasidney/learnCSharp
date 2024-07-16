// See https://aka.ms/new-console-template for more information
    
    Menu();

static void Menu() {
    
    Console.Clear();
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtracao");
    Console.WriteLine("3 - Multiplicacao");
    Console.WriteLine("4 - Divisao");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("--------------------");
    Console.WriteLine("Escolha uma Operação");
    
    short opcao = short.Parse(Console.ReadLine());
    
    switch (opcao)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
    
}
    
static void Soma()
{
    Console.Clear();
    Console.WriteLine("Primeiro numero: ");
    float n1 = float.Parse(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("Segundo numero: ");
    float n2 = float.Parse(Console.ReadLine());

    Console.Clear();
    Console.WriteLine($"Resultado: {n1 + n2} ");

    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Primeiro numero: ");
    float n1 = float.Parse(Console.ReadLine());
    
    Console.Clear();
    Console.WriteLine("Segundo numero: ");
    float n2 = float.Parse(Console.ReadLine());
    
    Console.Clear();
    Console.WriteLine($"Resultado: {n1 - n2} ");

    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Primeiro numero: ");
    float n1 = float.Parse(Console.ReadLine());
    
    Console.Clear();
    Console.WriteLine("Segundo numero: ");
    float n2 = float.Parse(Console.ReadLine());
    
    Console.Clear();
    Console.WriteLine($"Resultado: {n1 * n2} ");
    
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Primeiro numero: ");
    float n1 = float.Parse(Console.ReadLine());
    
    Console.Clear();
    Console.WriteLine("Segundo numero: ");
    float n2 = float.Parse(Console.ReadLine());
    
    Console.Clear();
    if (n2 == 0)
    {
        Console.WriteLine("Resultado: 1 ");   
    }
    else
    {
        Console.WriteLine($"Resultado: {n1 / n2} ");
    }
    
    Console.ReadKey();
    Menu();
}