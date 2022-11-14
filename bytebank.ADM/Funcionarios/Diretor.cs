namespace bytebank.ADM.Funcionarios;

public class Diretor : Funcionario
{
    // Reescreve metodo de classe pai ou classe Base
    public override double GetBonificacao()
    {
        // Usa base para usar o metodo da classe base -> Para não ser loop
        return this.Salario + base.GetBonificacao();
    }

    public override double PremioSemestral()
    {
        return Salario + base.PremioSemestral();
    }
}