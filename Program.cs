using System.Data.Common;

public class Funcionario
{
    private int id;
    private string endereco;
    private int matricula;
    private string nome;
    private string data_nascimento;
    private string cpf;
    private int id_departamento;
    private double salario;
    private string telefone;
    List<Funcionario> fun = new List<Funcionario>();
    public void Cadastrar_Funcionario(int id, string endereco, int matricula, string nome, string data_nascimento, string cpf, int id_departamento, double salario, string telefone)
    {
        
    }
}
public class Departamento
{
    private int id;
    private string nome;
    private int id_gerente;
    private string ramal;
    public void Cadastrar_Departamento(int id, string nome, int id_departamento, string ramal)
    {
        
    }
}
public class HistoricoDeFuncionario
{
    private int id_funcionario;
    private int id_departamento;
    private string data;
    private int id_novo_departamento;
}
public class HistoricoDeSalario
{
    private int id_funcionario;
    private double SalarioAnterior;
    private double NovoSalario;
    private string data; //mês e ano '
    public void CadastrarHistoricoDeSalario(int id_funcionario, double SalarioAnterior, double NovoSalario, string data)
    {
        
    }
}

