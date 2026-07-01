

namespace atividadegit.Model{
class GestaoDep
{
    private Departamento[] departamentos = new Departamento[10];
    private int indice = 0;

    public void CadastrarDepartamento(Departamento dep)
    {
       
        this.departamentos[indice] = dep;
        indice++;
        }
}
    

   
}
