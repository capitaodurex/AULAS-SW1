namespace atividade_produto;
class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new Produto();

        p1.AlteraPreco(10);
       p1.AlteraNome("Fita-Durex");
        p1.MostraDados();
    }
}
