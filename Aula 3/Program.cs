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


        Console.Write("Digite um número de 1 a 7: ");
        int numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-feira");
                break;
            case 3:
                Console.WriteLine("Terça-feira");
                break;
            case 4:
                Console.WriteLine("Quarta-feira");
                break;
            case 5:
                Console.WriteLine("Quinta-feira");
                break;
            case 6:
                Console.WriteLine("Sexta-feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Número inválido");
                break;
        }
    }
}

        Console.ReadLine();
    }


        Console.Write("Digite o código HTTP: ");
        int codigo = int.Parse(Console.ReadLine());

        string mensagem = codigo switch
        {
            200 => "OK - Requisição bem-sucedida",
            201 => "Criado - Recurso criado com sucesso",
            400 => "Erro 400 - Requisição inválida",
            401 => "Erro 401 - Não autorizado",
            404 => "Erro 404 - Página não encontrada",
            500 => "Erro 500 - Erro interno do servidor",
            _ => "Código HTTP desconhecido"
        };

        Console.WriteLine(mensagem);
    }

    {
        Console.Write("Digite seu peso em kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite sua altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (imc < 35)
        {
            Console.WriteLine("Obesidade grau I");
        }
        else if (imc < 40)
        {
            Console.WriteLine("Obesidade grau II");
        }
        else
        {
            Console.WriteLine("Obesidade grau III");
        }
    }
}


}
