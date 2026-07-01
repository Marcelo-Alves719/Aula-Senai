using System.IO.Pipes;
using System.Security.AccessControl;

public class HistoricoDeFuncionario
{
    public int id_funcionario;
    public int id_departamento;
    public string data;
    public int id_novo_departamento;
}

public class Doma
{

 public void AdicionarHistorico(int id_funcionario, int id_departamento, int id_novo_departamento)
    {
        string dia, mes, ano, data;

        Console.Write("Informe o dia de nascimento: ");
        dia = Console.ReadLine();

        Console.Write("Informe o mês de nascimento: ");
        mes = Console.ReadLine();

        Console.Write("Informe o ano de nascimento: ");
        ano = Console.ReadLine();

        data = ano + mes + dia;


    }
    private HistoricoDeFuncionario[] historico = new HistoricoDeFuncionario[1000];
    private int func = 0;

    public void AdicionarHistorico(int id_funcionario, int id_departamento, string data, int id_novo_departamento)
    {
        historico[func] = new HistoricoDeFuncionario();

        historico[func].id_funcionario = id_funcionario;
        historico[func].id_departamento = id_departamento;
        historico[func].data = data;
        historico[func].id_novo_departamento = id_novo_departamento;

        func++;
    }

    


}

