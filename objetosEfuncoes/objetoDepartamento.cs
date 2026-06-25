public class Departamento
{
    private int id;
    private string nome;
    private int id_gerente;
    private int ramal;

    Departamento[] dep = new Departamento[10];
    int iddepartamento = 0;
    public void Cadastrar_Departamento(string nome,int ramal,int id_gerent)
    {
        dep[iddepartamento].id = iddepartamento;
        dep[iddepartamento].nome = nome;
        dep[iddepartamento].id_gerente = id_gerent;
        dep[iddepartamento].ramal = ramal;
        iddepartamento++;
        
    
    }
}