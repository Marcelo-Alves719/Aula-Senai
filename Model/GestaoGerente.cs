namespace atividadegit.Model{
class GestaoGerente

{
     private objetoGerente[] ge = new objetoGerente[1000];
    private int indice = 0;

    public void CadastrarGernte(objetoGerente obj)
    {
       
        this.ge[indice] = obj;
        indice++;
        }

}
}