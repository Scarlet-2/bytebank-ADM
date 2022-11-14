namespace bytebank.ADM.Funcionarios.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonficacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonficacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            this.TotalDeBonficacao += diretor.GetBonificacao();
        }
    }
}
    
    /*
    // Sobrecarregar metodo
    public void Registrar(Diretor diretor)
    {
        this.TotalDeBonificacao += diretor.GetBonificacao();
    }
    */
