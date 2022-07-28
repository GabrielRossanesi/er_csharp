string valorPoupancaTexto;
float valorPoupanca;
Console.WriteLine("Digite o valor que você possui na conta poupança: ");
 valorPoupancaTexto = Console.ReadLine();
valorPoupanca = float.Parse(valorPoupancaTexto);


if (valorPoupanca > 100000){
    Console.WriteLine("Você cliente VIP possui uma taxa de juros diferenciada");
} else if (valorPoupanca > 50000) {
    Console.WriteLine("Você é um cliente especial, com taxa de juros de 1.2% a.m");
}
else {
    Console.WriteLine("Você é um cliente especial, mas sua taxa de juros é normal.(0,5% a.m) ");
}



Console.WriteLine("------------------------");    
Console.WriteLine("Programa finalizado");

Console.ReadKey();
