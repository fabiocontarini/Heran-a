using Exercicio7;

ContaCorrente conta1 = new ContaCorrente
{
    Banco = "Banco imobiliario",
    Agencia = "Ponto de renda",
    Conta = "4004-0001",
    Saldo = "16.500.000",
    limite = "30.000.000,00",
};
Console.WriteLine($"Você está no banco {conta1.Banco}. A agência que você possui é a {conta1.Agencia}, e o número da sua conta é {conta1.Conta}. Seu saldo atual é de {conta1.Saldo} e seu limite é de {conta1.limite}.");

Console.ReadKey();
