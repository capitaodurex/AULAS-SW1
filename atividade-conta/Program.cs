namespace atividade_conta;
class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Atividade Conta Bancária - Etec MCM");
        Conta conta = new Conta();

        conta.nomeCliente = "Capitão Durex";
        conta.ajustarLimite(800);
        conta.depositar(200);
        conta.sacar(300);

        double saldo = conta.ConsultaSaldo();
        
        //visualização:
        Console.WriteLine("Seu saldo é de: " + saldo);
    }
}
