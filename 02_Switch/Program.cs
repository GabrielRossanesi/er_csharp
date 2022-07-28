Console.WriteLine("Qual o seu estado civil? Informe: S - Solteiro, C - Casado, V - Viuvo, D - Divorciado");
string valor = Console.ReadLine().ToUpper(); 

switch (valor){
    case "S":
        Console.WriteLine("Você está solteiro, sugestão: Encontre alguém na rede social");
        break;

    case "C":
        Console.WriteLine("Você está casado, sugestão: Prepare uma noite especial!");
        break;

    case "V":
        Console.WriteLine("Você é viuvo, tente outra vez");
        break;

    case "D":
        Console.WriteLine("Você é divorciado, tente reatar");
        break;

    default:
        Console.WriteLine("Comando não reconhecido");
        break;
}

Console.ReadKey();