using bytebank.ADM.Funcionarios;

namespace bytebank.ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonficacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonficacao += funcionario.GetBonificacao();
        }
    }
}
