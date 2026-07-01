namespace atividadegit.Model{
class Departamento{
    public int Id;
    public string Nome;
    public int IdGerente;
    public int Ramal;
    private static int ContadorDepartamento = 0;

    public Departamento(String nome,int idgerente, int ramal)
        {
            
            if(ValidaRamal(ramal)){
            Nome = nome;
            Id = ContadorDepartamento;
            Ramal = ramal;
            ContadorDepartamento++;
            }
        }

    private bool ValidaRamal(int nramal)
    {
        return nramal > 99 && nramal < 1000; 
    }

    public int showDepNumber()
        {
            return ContadorDepartamento;
        }

}

}
