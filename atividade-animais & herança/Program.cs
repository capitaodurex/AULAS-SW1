namespace atividade_animais___herança;
class Program
{
    static void Main(string[] args)
     {
        Homem homem = new Homem();
        Cao cao = new Cao();
        Gato gato = new Gato();


        Console.WriteLine("O homem disse: " + homem.Fala());
        Console.WriteLine("O cãozinho disse: " + cao.Fala());
        Console.WriteLine("O gatinho disse: " + gato.Fala());
    }
}
