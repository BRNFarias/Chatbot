Console.WriteLine("Faça aqui a abertura do seu chamado!");
Console.WriteLine("Digite o seu nome: ");
string nome = Console.ReadLine() ?? "";
Console.WriteLine("Digite o seu e-mail: ");
string email = Console.ReadLine() ?? "";
Console.WriteLine("Digite o seu telefone: ");
string telefone = Console.ReadLine() ?? "";
Console.WriteLine("\n1 - abertura de chamado \n2 - Falar com suporte \n3 - sair");
string opcao = Console.ReadLine() ?? "";

switch (opcao)
{
    case "1":
        Console.WriteLine("Abrindo chamado...");
        break;
    case "2":
        Console.WriteLine("Transferindo para o suporte...");
        break;
    case "3":
        Console.WriteLine("Saindo do sistema...");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        return;
}