namespace atividade_conta;
class Conta
{
    
    public string? nomeCliente {get;set;}

    public int numeroConta {get; set;}

    public double saldo {get; set;}

    public double limite {get; set;}

    //ajustar limite

    public void ajustarLimite (double valor){
        this.limite = valor;
    }

    //realizar depósito
    public void depositar (double valor){
        this.saldo += valor;
    }

    //realizar saque
    public void sacar (double valor){
        if (valor <= this.saldo + this.limite) {
            Console.WriteLine("O valor sacado é de: " + saldo);
            this.saldo -= valor;
        }else {
            Console.WriteLine("Você não possui saldo+limite suficiente para esse saque.");
            Console.WriteLine("Saque não realizado.");
        }
    }
 
    //consultasaldo - ira retornar o saldo disponível + limite
    public double ConsultaSaldo(){
        return this.saldo + this.limite;
    }
}