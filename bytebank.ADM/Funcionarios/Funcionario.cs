
namespace bytebank.ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        
        public static int TotalDeFuncionarios { get; private set; }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }

        public Funcionario()
        {
            TotalDeFuncionarios++;
        }
    }
}