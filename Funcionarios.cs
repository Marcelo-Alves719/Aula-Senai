// See https://aka.ms/new-console-template for more information
class Funcionarios
{
    public static void doma()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine(); //nome completo

        Console.WriteLine("Digite seu id: ");
        string id = Console.ReadLine();

        Console.WriteLine("Digite sua matricula: ");
        string matricula = Console.ReadLine();

        Console.WriteLine("Digite seu CPF: ");
        string cpf = Console.ReadLine(); 

        Console.WriteLine("Digite sua Data de nascimento: "); //dia, mês e ano 
        string dataNascimento = Console.ReadLine();

        Console.WriteLine("Digite seu id de Departamento: ");
        string idDepartamento = Console.ReadLine(); 

        Console.WriteLine("Informe seu endereço: ");
        string endereco = Console.ReadLine(); //cep da rua e número da casa 

        Console.WriteLine("Informe o seu número de telefone: ");
        string telefone = Console.ReadLine(); // apenas números

        Console.WriteLine("Digite o valor do seu salário: ");
        double salario = double.Parse(Console.ReadLine());


     
      

    }
}
