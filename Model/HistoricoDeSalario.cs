namespace atividadegit.Model{
public class HistoricoDeSalario
{
    public  int id_funcionario;
    public  double SalarioAnterior;
    public double NovoSalario;
    public string data; //mês e ano '

    public HistoricoDeSalario(int id_fun, double SalarioAnterior, double NovoSalario, string data)
    {

        if(ValidaNovaSalario(NovoSalario)){
       id_funcionario = id_fun;
       this.SalarioAnterior = SalarioAnterior;
       this.NovoSalario = NovoSalario;
       this.data = data;
        }        
    }

    private bool ValidaNovaSalario(double novosalario)
        {
             return novosalario >= 1618;
        }
}
}