public class HistoricoDeSalario
{
    private int id_funcionario;
    private double SalarioAnterior;
    private double NovoSalario;
    private string data; //mês e ano '
    HistoricoDeSalario[] hsalario = new HistoricoDeSalario[1000];
    private int idhistoricosalario =0;
    public void CadastrarHistoricoDeSalario(int id_funcionario, double SalarioAnterior, double NovoSalario, string data)
    {

        hsalario[idhistoricosalario] = new HistoricoDeSalario();
        hsalario[idhistoricosalario].id_funcionario = id_funcionario;
        hsalario[idhistoricosalario].SalarioAnterior = SalarioAnterior;
        hsalario[idhistoricosalario].NovoSalario = NovoSalario;
        hsalario[idhistoricosalario].data = data;
    }
}