using System;

namespace questao01;
class questao01
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string? InputText = Console.ReadLine();

        if (InputText == null || InputText == "")
        {
            Console.WriteLine("Olá, Visitante! Seja muito bem-vindo!");
        }
        else
        {
            Console.WriteLine("Olá, " + InputText + "! Seja muito bem-vindo!");
        }
        /*
        //OU
        String Mensagem = "Olá, {0}! Seja muito bem-vindo!";
        if (InputText == null || InputText == "")
        {
            Console.WriteLine(string.Format(Mensagem, "Visitante"));
        }
        else
        {
            Console.WriteLine(string.Format(Mensagem, InputText));
        }
        */

        

    }
}