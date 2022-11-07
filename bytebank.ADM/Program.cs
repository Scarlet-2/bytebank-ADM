
using bytebank.ADM.Funcionarios;

Funcionario pedro = new Funcionario(0);
pedro.Nome = "Matheus Silveiro";
pedro.Cpf = "12345690";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());
