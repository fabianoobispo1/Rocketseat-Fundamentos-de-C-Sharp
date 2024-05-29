namespace questao02;
class questao02
{
    static void Main(string[] args)
    {

        Console.Write("Digite seu primeiro nome: ");
        string? primeiroNome = Console.ReadLine();

        Console.Write("Digite seu sobrenome nome: ");
        string? sobrenomeNome = Console.ReadLine();


        Console.Write("\nNome completo:"+primeiroNome+" "+sobrenomeNome+".");

        //ou 

        //Console.Write($"Nome completo:{primeiroNome} {sobrenomeNome}.");
        
    }
}