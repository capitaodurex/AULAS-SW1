namespace Exercicio_Aluno___LLB_2F;
class Desafio
{

    public string nomeprova="";

    public double numero1,numero2;

    public double media2(){
    double media2 = (numero1+numero2)/2;
    return (numero1+numero2)/2;
  }


 
  public void mensagem2(){
        double mediaCalculada2 = media2();
        Console.WriteLine("Sua média é: "+mediaCalculada2);
    }

}