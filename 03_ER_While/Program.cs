int i = 0;
while (i < 10){
    Console.WriteLine("Valor da variavel: " + i);
    i = i + 1;
}

int x = 0;
bool repetir = true;
while (repetir){
    Console.WriteLine("Valor da variavel x: " + x);
    if (x > 20){
        Console.WriteLine("Saindo do programa.");
        repetir = false;
    }
    x = x + 1;
}







Console.ReadKey();  