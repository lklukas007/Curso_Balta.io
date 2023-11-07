using System;
using System.IO;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------------------------");
            Iniciar();
        }

        public static void Iniciar()
        {
            var arquivo = new StringBuilder();

            do
            {
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

            Console.WriteLine("----------------------------------");
            SalvarArquivo(arquivo.ToString());
            Visualizador.Show(arquivo.ToString());
        }

        static void SalvarArquivo(string arquivo)
        {
            var caminhoPadraoArquivo = @"C:\TEMP\";
            var nomePadraoArquivo = "index.html";
            var caminhoCompletoArquivo = caminhoPadraoArquivo + nomePadraoArquivo;
            if (!Directory.Exists(caminhoPadraoArquivo))
            {
                Directory.CreateDirectory(caminhoPadraoArquivo);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Deseja salvar o arquivo?");
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1 PARA SALVAR ou 0 PARA NÃO SALVAR");
            var opcaoUsuario = short.Parse(Console.ReadLine());
            switch (opcaoUsuario)
            {
                case 1: CriarArquivo(arquivo, caminhoCompletoArquivo); break;
                case 0: Show(); break;
                default: Show(); break;
            }
        }

        private static void CriarArquivo(string arquivo, string caminhoCompletoArquivo)
        {
            try
            {
                File.WriteAllText(caminhoCompletoArquivo, arquivo.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro:" + ex.Message);
            }
        }
    }
}