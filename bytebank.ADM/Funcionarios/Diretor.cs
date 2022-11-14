
namespace bytebank.ADM.Funcionarios
{
    public class Diretor:Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }
    }    
}