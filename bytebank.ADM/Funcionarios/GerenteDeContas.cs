namespace bytebank.ADM.Funcionarios
{
    public class GerenteDeContas:Funcionario
    {       

        public GerenteDeContas(string cpf) : base(cpf,4000)
        {
            
        }
        
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
        
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }


    }
}
