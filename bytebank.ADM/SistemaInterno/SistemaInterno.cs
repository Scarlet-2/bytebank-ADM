using bytebank.ADM.Funcionarios;

namespace bytebank.ADM.SistemaInterno;

public class SistemaInterno
{
    public bool Logar(Diretor funcionario, string senha)
    {
        bool usuarioAutenticado = funcionario.Autenticar(senha);

        if (usuarioAutenticado)
        {
            Console.WriteLine("Bem-vindo ao sistema!");
            return true;
        }
        
        else
        {
            Console.WriteLine("Senha incorreta!");
            return false;
        }
    }

    // Sobrecarga antiga
    #region 
    /*
    public bool Logar(GerenteDeContas funcionario, string senha)
    {
        bool usuarioAutenticado = funcionario.Autenticar(senha);

        if (usuarioAutenticado)
        {
            Console.WriteLine("Bem-vindo ao sistema!");
            return true;
        }
        
        else
        {
            Console.WriteLine("Senha incorreta!");
            return false;
        }
    }
    */
    #endregion
}