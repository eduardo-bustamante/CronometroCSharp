internal class Program
{
    private static void Main(string[] args)
    {
       Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S - Segundo => 10 segundos, digite 10s");
        Console.WriteLine("M - Minuto => 3 minutos, digite 3m");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Quanto tempo deseja contar");

        string dados = Console.ReadLine().ToLower();
        char tipo = char.Parse(dados.Substring(dados.Length-1,1));
        int tempo = int.Parse(dados.Substring(0, dados.Length-1));
        int multiplicador = 1;

        if (tipo == 'm')
        {
            multiplicador=60;
        }

        if (tempo == 0)
        {
            System.Environment.Exit(0);
        }

        Start(tempo * multiplicador);
    }

    static void Start(int tempo)
    {
        int atualTempo = 0;
        
        while (atualTempo!=tempo)
        {
            Console.Clear();
            atualTempo++;
            Console.WriteLine(atualTempo);
            Thread.Sleep(1000); //para fazer o cronometro saltar de um segundo
        }

        Console.WriteLine("Cronometro Finalizado!");
        Thread.Sleep(2500);
        Menu();
    }
}