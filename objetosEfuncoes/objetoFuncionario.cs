using System.Data.Common;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
namespace ObjetosEfuncoes.ObjetosEfuncoes{
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
    public Funcionario[] fn = new Funcionario[1000];
    private int idFuncionario = 0;
    public void Cadastrar_Funcionario(string endereco, int matricula, string nome, string data_nascimento, string cpf, int id_departamento, double salario, string telefone)
    {
        
        fn[idFuncionario].endereco = endereco;
        fn[idFuncionario].id = idFuncionario;
        fn[idFuncionario].nome = nome;
        fn[idFuncionario].data_nascimento = data_nascimento;
        fn[idFuncionario].cpf = cpf;
        fn[idFuncionario].matricula = idFuncionario*12-7;
        fn[idFuncionario].id_departamento = id_departamento;
        fn[idFuncionario].salario = salario;
        fn[idFuncionario].telefone = telefone;
        idFuncionario++;


    }
   private bool validaSalario(double salario)
        {
            return salario > 1600;
        }

    
}}




