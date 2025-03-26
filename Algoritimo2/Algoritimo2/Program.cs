int idade = 10;
string nomeCliente = "Charles Vitale";
decimal preco = 20M;
char letra = 'a';
var nomeCompleto = "Charles Kunde Vitale";
var altura = 180;
var msg = " thank You";

Console.Write("Digite seu nome: ");
nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Bem Vindo " + nomeCompleto);
Console.WriteLine();
Console.Write("Digite Sua idade: ");
var linha = Console.ReadLine();
idade = int.Parse(linha);
Console.WriteLine("Idade informada " + idade  + msg);
if (idade < 18)
    Console.WriteLine("Voce nao pode estar aqui!");

Console.ReadKey();
