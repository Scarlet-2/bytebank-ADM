
using bytebank.ADM.Funcionarios;
using bytebank.ADM.Funcionarios.Utilitario;

Funcionario pedro = new Funcionario(1);
pedro.Nome = "Matheus Silveiro";
pedro.Cpf = "12345690";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberto = new Diretor();
roberto.Nome = "Roberto Inacio";
roberto.Cpf = "1231415";
roberto.Salario = 5000;

Console.WriteLine(roberto.Nome);
Console.WriteLine(roberto.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(pedro);
gerenciador.Registrar(roberto);

Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");
