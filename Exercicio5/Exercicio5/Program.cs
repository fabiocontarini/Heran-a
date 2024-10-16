
using Exercicio5;

//instanciando a clasxse funcionario
funcionario func1 = new funcionario { nome = "Rafael", idade = 30 };

//chamando o metodo de envelhecer

func1.Envelhecer(10); //somar a idade que voce passou para a variavel func1 mais 10 

funcionario func2 = new funcionario { nome = "Fábio", idade = 25 };

func2.AguaDaVida(5); // subtrair a idade que voce passou para a variavel func1

funcionario func3 = new funcionario { nome = "Larissa", idade = 25 };

func3.AguaDaVida(5); 

funcionario func4 = new funcionario { nome = "José", idade = 25 };

func4.AguaDaVida(5);

funcionario func5 = new funcionario { nome = "João", idade = 40 };

func5.AguaDaVida(16);

funcionario func6 = new funcionario { nome = "Maria", idade = 41 };

func6.AguaDaVida(15);

funcionario func7 = new funcionario { nome = "Ana", idade = 30 };

func7.Envelhecer(15);

funcionario func8 = new funcionario { nome = "Afonso", idade = 25 };

func8.Envelhecer(5);

funcionario func9 = new funcionario { nome = "Mario", idade = 40 };

func9.Envelhecer(10);

funcionario func10 = new funcionario { nome = "Luigi", idade = 30 };

func10.Envelhecer(15);

//exibindo as informações do funcionário  
Console.WriteLine($"Nome: {func1.nome}, idade: {func1.idade}\nNome: {func2.nome}, idade: {func2.idade}\nNome: {func3.nome}, idade: {func3.idade}\nNome: {func4.nome}, idade: {func4.idade}\nNome: {func5.nome}, idade: {func5.idade}\nNome: {func6.nome}, idade: {func6.idade}\nNome: {func7.nome}, idade: {func7.idade}\nNome: {func8.nome}, idade: {func8.idade}\nNome: {func9.nome}, idade: {func9.idade}\nNome: {func10.nome}, idade: {func10.idade}");

//encerra o programa 
Console.WriteLine("\nPressione qualquer tecla para encerrar...");
Console.ReadKey();

