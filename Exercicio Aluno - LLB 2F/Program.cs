namespace Exercicio_Aluno___LLB_2F;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.nome = "Fabrício Augusto Ponsoni";
        aluno1.nota1 = 4.3;
        aluno1.nota2 = 9.9;

        aluno1.mensagem();


        //TESTE - DESAFIO

        Desafio alunoteste = new Desafio();

            Console.Write("Primeiro, digite o seu nome: ");
            string? nomeprova = Console.ReadLine();
            Console.WriteLine("Bem vindo(a) " +nomeprova);
            Console.Write("Digite a sua primeira nota (Nota1): ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sua primeira nota é: " +numero1);
            Console.Write("Digite a sua segunda nota (Nota2): ");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sua segunda nota é: " +numero2);
            Console.WriteLine("Sua média é: " + (numero1+numero2)/2);
    }

}
