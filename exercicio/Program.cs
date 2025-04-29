class Program
{
    static void Main()
    {
        int valor = 1;

        switch (valor)
        {
            case 1:
                Console.WriteLine("Valor digitado foi 1");
                break;
            case 2:
                Console.WriteLine("Valor digitado foi 2");
                break;
            default:
                Console.WriteLine("Valor não digitado.");
                break;
        }
    }
}