namespace Cronometro
{
    public static class CronometroMain
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Selecione uma opção:");

            string entradaUsuario = Console.ReadLine().ToLower();

            ValidarUsuarioDesejaSair(entradaUsuario);

            char tipoTempo = char.Parse(entradaUsuario.Substring(entradaUsuario.Length - 1, 1));

            int tempo = int.Parse(entradaUsuario.Substring(0, entradaUsuario.Length - 1));

            int multiplicador = 1;

            if (tipoTempo == 'm')
                multiplicador = 60;

            MensagemInicial(tempo * multiplicador);

        }
        static void Start(int tempo)
        {
            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado.");
            Thread.Sleep(1500);
            Menu();
        }

        static string ValidarUsuarioDesejaSair(string entradaUsuario)
        {
            if (int.TryParse(entradaUsuario, out int resultado))
            {
                if (resultado == 0)
                {
                    Console.WriteLine("Tchau!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    System.Environment.Exit(0);
                }
                return "Tchau!";
            }
            else
                return entradaUsuario;
        }

        static void MensagemInicial(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(800);
            Console.WriteLine("Apontar...");
            Thread.Sleep(800);
            Console.WriteLine("Fogo!");
            Thread.Sleep(800);

            Start(tempo);
        }
    }
}