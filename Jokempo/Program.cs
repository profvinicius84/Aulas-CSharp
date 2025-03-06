// See https://aka.ms/new-console-template for more information
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");
Console.WriteLine("1 - Sim ou 0 - Não");

var continuar = Console.ReadKey().KeyChar;

while(continuar == '1')
{
    Console.WriteLine("Então vamos começar...");
    Console.WriteLine("Escolha uma opção: 0 - Pedra ✊, 1 - Papel ✋ ou 2 - Tesoura ✌");
    var opcao = Console.ReadKey().KeyChar;

    var opcaoPC = new Random().Next(3);

    bool vitoria = false;

    switch (opcao)
    {
        case '0':
            Console.WriteLine("\nVocê escoheu Pedra ✊!");
            vitoria = (opcaoPC == 2);
            break;
        case '1':
            Console.WriteLine("\nVocê escoheu Papel ✋");
            vitoria = (opcaoPC == 0);
            break;
        case '2':
            Console.WriteLine("\nVocê escoheu Tesoura ✌");
            vitoria = (opcaoPC == 1);
            break;
    }

    switch (opcaoPC)
    {
        case 0:
            Console.WriteLine("\nEu escolhi Pedra ✊!");
            break;
        case 1:
            Console.WriteLine("\nEu escolhi Papel ✋");
            break;
        case 2:
            Console.WriteLine("\nEu escolhi Tesoura ✌");
            break;
    }

    if (int.Parse(opcao.ToString()) == opcaoPC)
        Console.WriteLine("\n😀 Legal! Nós empatamos!");
    else if (vitoria)
        Console.WriteLine("\n😀 Parabéns! Você venceu.");
    else
        Console.WriteLine("\n😀 Haha, eu venci! Não foi dessa vez. Você pode ter mais sorte na próxima.");

    Console.WriteLine("\nQuer jogar de novo?");
    Console.WriteLine("1 - Sim ou 0 - Não");
    continuar = Console.ReadKey().KeyChar;
}
Console.WriteLine("👋 Tchau! Até a próxima");
/////