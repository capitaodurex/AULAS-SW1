namespace atividade_construtor;
class Produto
{

//1º Método
    public Produto(){
        this.Nome = "XPTO";
        this.Preco = 1;
    }
//2º Método
    public Produto(double preco){
        this.Nome = "NÃO INFORMADO";
        this.Preco = preco;
    }

//3º Método
 public Produto(string nome, int desconto){
        this.Nome = "nome";
        this.Preco = 10 - 10*desconto/100;
    }


    private string? Nome{get;set;}

    private double Preco{get;set;}

    public void MostraDados(){
        Console.WriteLine("Nome: " + this.Nome );
        Console.WriteLine("Preço: " + this.Preco);
    }

     public void AlteraPreco(double preco){
        if(preco >= 0){
            this.Preco = preco;
        }else{
            Console.WriteLine("VALOR INVÁLIDO");
        }
    }

      public void AlteraNome(string nome){
       this.Nome = nome; 
    }
}
