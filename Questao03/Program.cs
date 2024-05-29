namespace questao03;

class questao03
{
    static void Main(string[] args)
    {

        Console.Write("Digite o primeiro valor: ");
        string? vl1 = Console.ReadLine();
        if (vl1 == null)
        {
            vl1 = "";
        }
        double Valor01 = 0;

        if (Double.TryParse(vl1, out Valor01))
        {
            Valor01 = double.Parse(vl1);
        }
        else
        {
            Console.Write("Primeiro valor digitado e invalido.");
            return;
        }


   
        

        Console.Write("Digite o segundo valor: ");
        string? vl2 = Console.ReadLine();

        if (vl2 == null)
        {
            vl2 = "";
        }
        double Valor02 = 0;

        if (Double.TryParse(vl2, out Valor01))
        {
            Valor02 = double.Parse(vl2);
        }
        else
        {
            Console.Write("Primeiro valor digitado e invalido.");
            return;
        }


        Console.WriteLine();
        Console.WriteLine($"SOMA:{(Valor01 + Valor02)}");
        Console.WriteLine($"SUBTRAÇÃO:{(Valor01 - Valor02)}");
        Console.WriteLine($"MULTIPLICAÇÃO:{(Valor01 * Valor02)}");
        if ((Valor01 == 0 && Valor02 == 0) || (Valor01 > 0 && Valor02 == 0))
        {
            Console.WriteLine("DIVISÃO: Não é possível dividir 0 para 0.");
        }
        else
        {
            Console.WriteLine($"DIVISÃO:{(Valor01 / Valor02)}");
        }
        Console.WriteLine($"MÉDIA:{((Valor01 + Valor02) / 2)}");

    }
}