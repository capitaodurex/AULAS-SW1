namespace atividade_contratos___funcionarios;
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

}
