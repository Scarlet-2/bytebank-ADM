using bytebank.ADM.Funcionarios;
using bytebank.ADM.Utilitario;

// Para observação e comparação APENAS
#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro malazartes";


//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonficacao);
//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);

//Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);
#endregion

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer marcelo = new Designer("132546");
    marcelo.Nome = "Marcelo do Santos";

    Diretor paulo = new Diretor("987555");
    paulo.Nome = "Paulo Oliveira";

    Auxiliar lucas = new Auxiliar("745667");
    lucas.Nome = "Lucas Obedi";

    GerenteDeContas marcos = new GerenteDeContas("859049");
    marcos.Nome = "Marcos Oliveira";

    gerenciador.Registrar(marcos);
    gerenciador.Registrar(lucas);
    gerenciador.Registrar(paulo);
    gerenciador.Registrar(marcelo);

    Console.WriteLine("Total de Bonificação = "+ gerenciador.TotalDeBonficacao);
}





