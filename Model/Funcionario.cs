namespace atividadegit.Model{

    class Funcionario
    {
        private static int idFuncionario = 1;

        private int id;
        private string endereco;
        private int matricula;
        private string nome;
        private int data_nascimento;
        private string cpf;
        private int id_departamento;
        private double salario;
        private string telefone;

        public void Cadastrar_Funcionario(string endereco, int matricula, string nome, int data_nascimento, string cpf, int id_departamento, double salario, string telefone)
        {
            id = idFuncionario;
            idFuncionario++;
            this.endereco = endereco;
            this.matricula = matricula;
            this.nome = nome;
            this.data_nascimento = data_nascimento;
            this.cpf = cpf;
            this.id_departamento = id_departamento;
            this.salario = salario;
            this.telefone = telefone;
        }

        private bool ValidaSalario(double salario)
        {
            return salario > 1600;
        }

        public bool ValidaFuncionario(int data, string nome)
        {
            if (nome.Length < 3)
            {
                Console.WriteLine("Informe um nome válido, por favor.");
                return false;
            }

            if (data < 19500620)
            {
                Console.WriteLine("Informe uma data de nascimento válida, que seja maior que 20/06/1950.");
                return false;
            }

            if (!ValidaSalario(salario))
            {
                Console.WriteLine("Salário inválido.");
                return false;
            }

            return true;
        }
    }
}