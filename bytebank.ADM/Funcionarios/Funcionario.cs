namespace bytebank.ADM.Funcionarios;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public double Salario { get; set; }
    private double tipo; // 0 - Funcionario / 1 - Patrão / 
    public int TotalDeFuncionarios { get; private set; }

    // Com virtual pode ser reescrito
    public virtual double GetBonificacao()
    {
        return this.Salario * 0.10;
    }
    
    public virtual double PremioSemestral()
    {
        return Salario + (this.Salario * 0.20);
    }

    public Funcionario(int tipo)
    {
        this.tipo = tipo;
    }

    public Funcionario()
    {
        TotalDeFuncionarios++;
        // Feito para debug 
        // Console.WriteLine("Funcionario Criado");
    }
}