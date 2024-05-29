using System.Threading.Channels;

namespace questao04;

class questao04
{
    static void Main(string[] args)
    {
        string? palavra = Console.ReadLine();
        int contagem = 0;

        if (palavra == null)
        {
            palavra = "";
        }

        for (int i = 0; i < palavra.Length; i++)
        {
            if (!palavra[i].ToString().Contains(' '))
            {
                contagem++;
            };
        }
        Console.WriteLine(contagem);
    }
}