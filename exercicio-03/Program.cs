class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a nota bimestral (0 a 10):");
        double nota = Convert.ToDouble(Console.ReadLine());
        string conceito;

        if (nota < 0 || nota > 10)
        {
            conceito = "X"; 
        }
        else if (nota >= 9.0)
        {
            conceito = "A";
        }
        else if (nota >= 8.0)
        {
            conceito = "B";
        }
        else if (nota >= 6.0)
        {
            conceito = "C";
        }
        else if (nota >= 4.0)
        {
            conceito = "D";
        }
        else
        {
            conceito = "E";
        }

        switch (conceito)
        {
            case "A":
                Console.WriteLine("Conceito: A - Excelente");
                break;
            case "B":
                Console.WriteLine("Conceito: B - Bom");
                break;
            case "C":
                Console.WriteLine("Conceito: C - Regular");
                break;
            case "D":
                Console.WriteLine("Conceito: D - Ruim");
                break;
            case "E":
                Console.WriteLine("Conceito: E - Péssimo");
                break;
            default:
                Console.WriteLine("Nota inválida. Digite um valor entre 0 e 10.");
                break;
        }
    }
}
