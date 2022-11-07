namespace bytebank.ADM.Funcionarios;

public class Diretor
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public double Salario { get; set; }
    private double tipo = 1; // 0 - Funcionario / 1 - Patrão /
    
    public double GetBonificacao()
    {
        return this.Salario;
    }
}