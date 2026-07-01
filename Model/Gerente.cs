
namespace atividadegit.Model{

public class objetoGerente
{
    public string nome;
    public int id;
    int contadorGerente=0;



    public void cadastrar_Gerente(string nome)
    {
      this.nome = nome;
      id = contadorGerente++;
        
    }
}
}