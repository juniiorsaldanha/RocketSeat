using System.Diagnostics;
using System.Text;

namespace RocketSeat; 
class RocketSeat
{
    static void Main(string[] args)
    {
        //Exercicio 1
        //Exercicio1();

        //Exercicio 2
        //Exercicio2();

        //Exercicio 3
        //Exercicio3(); 

        //Exercicio 4
        //Exercicio4();

        //Exercicio 5
        //Console.WriteLine(Exercicio5());

        //Exercicio 6
        Exercicio6();
    }

    static void Exercicio1()
    {
        Console.Write("Digite seu nome: ");
        string? nome1 = Console.ReadLine();
        Console.WriteLine($"Olá, {nome1}! Seja muito bem-vindo!");
    }

    static void Exercicio2()
    {
        Console.Write("Digite seu nome: ");
        string? nome2 = Console.ReadLine();
        Console.Write("Digite seu sobrenome: ");
        string? sobrenome = Console.ReadLine();

        Console.WriteLine($"{nome2} {sobrenome}");
    }

    static void Exercicio3()
    {
        double valor1 = 0;
        double valor2 = 0;

        Console.Write("Digite o valor 1: ");
        valor1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o valor 2: ");
        valor2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(valor1 - valor2);
        Console.WriteLine(valor1 * valor2);
        Console.WriteLine(valor1 + valor2); 

        if (valor2 != 0)
            Console.WriteLine(valor1 / valor2); 
        Console.WriteLine((valor1 + valor2) / 2);
    }

    static void Exercicio4()
    {
        Console.Write("Digite uma ou mais palavras: "); 
        string? texto = Console.ReadLine();

        int count = 0; 
        
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] == ' ')
                continue;
            count++; 
        }

        Console.WriteLine(count); 
    }

    static bool Exercicio5()
    {
        Console.Write("Digite a placa do veiculo: "); 
        string? placa = Console.ReadLine();

        if(placa.Length != 7)
            return false; 

        for(int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
                return false;
        }

        for(int i = 3; i < placa.Length; i++)
        {
            if (!char.IsDigit(placa[i]))
                return false;
        }

        return true; 
       
    }

    static void Exercicio6()
    {
        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("Escolha o formato de exibição da data atual:");
        Console.WriteLine("1. Formato completo");
        Console.WriteLine("2. Apenas a data (DD/MM/AAAA)");
        Console.WriteLine("3. Apenas a hora (HH:MM:SS)");
        Console.WriteLine("4. A data com o mês por extenso");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Data atual no formato completo: {0}", dataAtual.ToString("dddd, dd/MM/yyyy HH:mm:ss"));
                break;
            case 2:
                Console.WriteLine("Apenas a data: {0}", dataAtual.ToString("dd/MM/yyyy"));
                break;
            case 3:
                Console.WriteLine("Apenas a hora: {0}", dataAtual.ToString("HH:mm:ss"));
                break;
            case 4:
                Console.WriteLine("Data com o mês por extenso: {0}", dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}