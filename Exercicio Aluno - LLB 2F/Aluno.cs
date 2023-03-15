namespace Exercicio_Aluno___LLB_2F;
class Aluno
{
  public string nome="";

  public double nota1, nota2;

  //Média
    public double obterMedia(){
    double media = (nota1+nota2)/2;
    return media;
  }

  //Situação
    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="Aprovado!";
        }else{
            situacao="Reprovado :(";
        }
        return situacao;
    }

    //Mensagem
    
    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome+" está "+resultadoSituacao+" com média: "+mediaCalculada);
    }
}
 