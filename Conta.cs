namespace Aula13Uber
{
    public class Conta
    {
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public string Cadastrar(){
            
            System.Console.WriteLine("Digite a agência");
            Agencia = System.Console.ReadLine();

            System.Console.WriteLine("Digite a conta corrente");
            ContaCorrente = System.Console.ReadLine();

            return "Dados da Conta Cadastrados";

        }
        public void Excluir(){
            Agencia = "";
            ContaCorrente = "";
        }

    }
}
