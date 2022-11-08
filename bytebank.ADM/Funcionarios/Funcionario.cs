namespace bytebank.ADM.Funcionarios;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public double Salario { get; set; }
    private double tipo; // 0 - Funcionario / 1 - Patrão / 

    // Com virtual pode ser reescrito
    public virtual double GetBonificacao()
    {
        if (tipo == 1)
        {
            return this.Salario;
        }
        return this.Salario * 0.10;
    }

    public Funcionario(int tipo)
    {
        this.tipo = tipo;
    }
    
    public Funcionario()
    {
    }
}