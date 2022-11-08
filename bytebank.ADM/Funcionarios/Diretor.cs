namespace bytebank.ADM.Funcionarios;

public class Diretor : Funcionario
{
    // Reescreve metodo de classe pai ou classe Base
    public override double GetBonificacao()
    {
        return this.Salario;
    }
}