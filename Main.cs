
class Main{
public static void main(string[] args){


int Cadastrar_Departamento = 0;
int id = 0;
int id_gerente = 0;
int i = 0;

Console.WriteLine("Bem-Vindo(a) ao cadastro, o que você deseja? \n 0-Sair \n 1-Cadastrar departamento");
Cadastrar_Departamento=int.Parse(Console.ReadLine());

do
{
    Console.WriteLine("Bem-Vindo(a) ao cadastro, o que você deseja? \n 0-Sair \n 1-Cadastrar departamento");
    Cadastrar_Departamento=int.Parse(Console.ReadLine());
    i++;
}
while(Cadastrar_Departamento>=2);

switch (Cadastrar_Departamento){


    case 1:
    Console.WriteLine("Insira o id do departamento");
    id=int.Parse(Console.ReadLine());
    
    Console.WriteLine("Insira o nome do departamento");
    string nome = Console.ReadLine();
    
    Console.WriteLine("Insira o id do gerente do departamento");
    id_gerente=int.Parse(Console.ReadLine());
    
    Console.WriteLine("Insira o ramal do departamento");
    string ramal = Console.ReadLine();

    break;
    
    case 0:
    Console.WriteLine("Aplicativo fechado.");
    break;

    

}




}
}
