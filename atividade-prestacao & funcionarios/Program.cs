﻿namespace atividade_prestacao___funcionarios;
class Program
{
    static void Main(string[] args)
    {
      //Contratos
        PessoaFisica contratofisico = new PessoaFisica();
        PessoaJuridica contratojuridico = new PessoaJuridica();

        //Nomes (Ambos)
        contratofisico.Nome = "Luciano Leme Barros | ";
        contratojuridico.Nome = "Lucca Maximuss | ";

        //Emails (Ambos)
        contratofisico.Email = "lucianolemebarros@gmail.com | ";
        contratojuridico.Email = "espectrosjp.lucca@gmail.com | ";

        //Números de Telefone (Ambos)
        contratofisico.Telefone = "+55 (11) 95812-2064 | ";
        contratojuridico.Telefone = "+44 (20) 94002-8922 | ";

        //Prazo (Ambos - Exemplo: 12 meses)
        contratofisico.Prazo = 12;
        contratojuridico.Prazo = 12;


        //Apenas Pessoa Física
        contratofisico.CPF = "000.000.000-00 | ";
        contratofisico.Idade = 15 ;

        
        //Apenas Pessoa Jurídica
        contratojuridico.CNPJ = "000000000 | ";
        contratojuridico.InscricaoEstadual = "00000000000 | ";
        contratojuridico.NomedaEmpresa = "Espectro SJP | ";


    Console.WriteLine("Central - Pessoa Física: " + contratofisico.Exibir() + " | PRESTAÇÃO - Pessoa Física:" + contratofisico.calcularPrestacao());
    Console.WriteLine("Portal - Pessoa Jurídica: " + contratojuridico.Exibir() + "| PRESTAÇÃO - Pessoa Jurídica:" + contratojuridico.calcularPrestacao());
    }
}
