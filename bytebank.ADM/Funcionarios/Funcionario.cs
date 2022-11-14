namespace bytebank.ADM.Funcionarios;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cpf { get; private set; }
    public double Salario { get; set; }
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

    public Funcionario(string cpf)
    {
        TotalDeFuncionarios++;
        // Feito para debug 
        // Console.WriteLine("Funcionario Criado");
    }
}