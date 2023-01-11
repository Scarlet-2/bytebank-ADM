namespace bytebank_ADM.Parceira;

public class ParceiroComercial
{
    public string Senha { get; set; }

    public bool Autenticar(string senha)
    {
        return this.Senha == senha;
    }
}