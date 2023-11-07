namespace EditorDeTexto
{
    public static class EditorTextoMain
    {

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 -  Abrir arquivo existente");
            Console.WriteLine("2 -  Criar novo arquivo");
            Console.WriteLine("0 -  Sair");

            short opcaoUsuario = short.Parse(Console.ReadLine());

            switch (opcaoUsuario)
            {
                case 0: Sair(); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo de texto que deseja abrir?");
            string caminho = Console.ReadLine();

            using (var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();

                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {

            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo - (ESC para sair)");
            Console.WriteLine("------------------------");

            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(texto);
        }

        static void Salvar(string texto)
        {
            Console.Clear();

            Console.WriteLine("Em qual caminho deseja salva o arquivo?");

            var caminhoArquivo = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminhoArquivo))
            {
                arquivo.Write(texto);
            }

            Console.WriteLine($"Arquivo salvo com sucesso no caminho: {caminhoArquivo}");
            Console.ReadLine();
            Menu();
        }
        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Tchau!");
            Thread.Sleep(500);
            Console.Clear();
            System.Environment.Exit(0);
        }
    }
}