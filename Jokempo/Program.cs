// See https://aka.ms/new-console-template for more information
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");
Console.WriteLine("1 - Sim ou 0 - Não");
if(Console.ReadKey().KeyChar == '1')
{
    Console.WriteLine("Então vamos começar...");
    Console.WriteLine("Escolha uma opção: 0 - Pedra ✊, 1 - Papel ✋ ou 2 - Tesoura ✌");
    var opcao = Console.ReadKey().KeyChar;
    Console.WriteLine("Desculpa! Acabei de lembrar que ainda não sei jogar. 😕");
}
Console.WriteLine("👋 Tchau! Até a próxima");