namespace bytebank.ADM.Funcionarios;

public class Diretor : Funcionario
{
    public double GetBonificacao()
    {
        return this.Salario;
    }
}