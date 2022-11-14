using bytebank.ADM.Funcionarios;
using bytebank.ADM.Funcionarios.Utilitario;

Funcionario pedro = new Funcionario();
pedro.Cpf = "123456789";
pedro.Salario = 2000;
pedro.Nome = "Pedro malazartes";

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor();
roberta.Cpf = "987654321";
roberta.Salario = 5000;
roberta.Nome = "Roberta Silva";

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonficacao}");
