namespace bytebank.ADM.Funcionarios.Utilitario;

public class GerenciadorDeBonificacao
{
    public double TotalDeBonificacao { get; private set; }

    public void Registrar(Funcionario funcionario)
    {
        this.TotalDeBonificacao += funcionario.GetBonificacao();
    }
    
    // Sobrecarregar metodo
    public void Registrar(Diretor diretor)
    {
        this.TotalDeBonificacao += diretor.GetBonificacao();
    }
}