class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua Nota: ");
        string nota = Console.ReadLine();

   

        int? numroValido = null;
        int valor = numroValido ?? 0;

        int ValidadorDeNota = (int.Parse(nota));
        



        if (ValidadorDeNota >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else if (ValidadorDeNota >= 5)
        {
            Console.WriteLine("Recuperação");
        }

        else
        {
            Console.WriteLine("Reprovado");
        }

          Console.WriteLine("Fale 1 a 7: ");
        string Dia = Console.ReadLine();

     switch (Dia) { 

        case "1":
                string = Dia = Console.Read("SEGUNDA");
             break;


            case "dom":​

    Console.WriteLine("Fim de semana");​

    break;​

    default:​

    Console.WriteLine("Dia util");​

    break;​

}​

        Console.ReadLine();
    }
}