namespace bytebank.ADM.Funcionarios
{
    public class Diretor: Funcionario
    { 

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public Diretor(string cpf):base(cpf,5000)
        {
            
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15; 
        }

    }

    
}
