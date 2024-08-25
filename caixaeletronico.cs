double saldo = 1000;
bool ativo = true;

while(ativo)
{
    Console.WriteLine("1- Consultar o saldo");
    Console.WriteLine("2- Sacar");
    Console.WriteLine("3- Depositar");
    Console.WriteLine("4- Sair");
    string? opcao = Console.ReadLine();

switch(opcao)
{
case "1":
    Console.WriteLine("seu saldo é: " + saldo);
    break;
case "2":
    Console.WriteLine("Digite o valor do saque: ");
    double saque = Convert.ToDouble(Console.ReadLine());
    break;
case "3":
    Console.WriteLine("Digite o valor do depósito: ");
    double deposito = Convert.ToDouble(Console.ReadLine());
    saldo += deposito;
    break;
case "4":
    Console.WriteLine("Saindo do sistema");
    ativo = false;
    break;
default:
    Console.WriteLine("Opção inválida");
    break;
}
}
