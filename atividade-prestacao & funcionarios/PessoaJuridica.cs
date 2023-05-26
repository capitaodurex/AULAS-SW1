namespace atividade_prestacao___funcionarios;
class PessoaJuridica:Contrato
{
    //Cnpj da empresa
    public string? CNPJ {get; set;}
    //Inscrição estadual do contratante
    public string? InscricaoEstadual {get; set;}
    //Nome da Empresa
    public string? NomedaEmpresa {get; set;}

        //Exibir os dados
            public override string Exibir()
            {
                return base.Exibir() + "Nº do CNPJ: " + this.CNPJ + "Incrição Estadual: " + this.InscricaoEstadual + "Nome da Empresa: " + this.NomedaEmpresa;
            }

    //Calcular Prestação + Adicional Juridico
     public override double calcularPrestacao()
    {
        return ((base.calcularPrestacao()/Prazo)+3);
    }
}

