namespace atividade_prestacao___funcionarios;

class Contrato
{
    //Nome da pessoa 
    public string? Nome {get; set;} 
    //Email da pessoa
    public string? Email {get; set;}
    //Nº de Telefone da pessoa
    public string? Telefone {get; set;}
    //Prazo do Contrato
    public int Prazo {get;set;}

    public virtual string Exibir(){
        return "Nome: " + this.Nome + "Email: " + this.Email + "Telefone: " + this.Telefone;
    }

     public virtual double calcularPrestacao(){
        return 1000;
    }
}

