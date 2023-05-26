namespace atividade_prestacao___funcionarios;
class PessoaFisica:Contrato
{
    //Cpf 
    public string? CPF {get; set;}
    //Idade do Contratante
    public int Idade {get; set;}

        //Exibir os dados
            public override string Exibir()
            {
                return base.Exibir() + "Nº de CPF: " + this.CPF + "Idade: " + this.Idade;
            }

    //Calculo de Prestação + Adicional de Idade
      public override double calcularPrestacao()
    {
            if (Idade <= 30) {

            return ((base.calcularPrestacao()/Prazo)+1);

            } else if (Idade <= 40) {

            return ((base.calcularPrestacao()/Prazo)+2);

            } else if (Idade <= 50) {

            return ((base.calcularPrestacao()/Prazo)+3);

            } else {

            return ((base.calcularPrestacao()/Prazo)+4);

            }
        
    }

}
